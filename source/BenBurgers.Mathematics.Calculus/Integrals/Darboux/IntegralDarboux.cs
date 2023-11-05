﻿/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using System.Numerics;

namespace BenBurgers.Mathematics.Calculus.Integrals.Darboux;

/// <summary>
/// A Darboux integral.
/// </summary>
/// <typeparam name="TNumber">The type of number in the domain and range of the integral's function.</typeparam>
public sealed partial class IntegralDarboux<TNumber> : Integral<TNumber, SyncArgs<TNumber>, AsyncArgs<TNumber>>
    where TNumber : INumber<TNumber>
{
    /// <summary>
    /// Initializes a new instance of <see cref="IntegralDarboux{TNumber}" />.
    /// </summary>
    /// <param name="func">The integrated function.</param>
    public IntegralDarboux(Integral<TNumber>.IntegralFunction func)
        : base(func)
    {
    }

    private static TNumber DarbouxPerformThread(object? state)
    {
        if (state is not ThreadState { } threadState)
            throw new InvalidOperationException();

        var sum = TNumber.Zero;
        var startAdjusted = threadState.start + threadState.step;
        for (var i = startAdjusted; i <= threadState.end; i += threadState.step)
        {
            threadState.cancellationToken.ThrowIfCancellationRequested();
            sum +=
                Step(
                    threadState.func,
                    threadState.mode == IntegralDarbouxMode.Lower
                        ? i - threadState.step
                        : i,
                    threadState.step);
        }
        return sum;
    }

    private static TNumber Step(
        Integral<TNumber>.IntegralFunction func,
        TNumber intervalStart,
        TNumber step)
    {
        return func(intervalStart) * step;
    }

    /// <summary>
    /// Calculates an approximation of the integral using the Darboux algorithm.
    /// </summary>
    /// <returns>The approximation of the integral with the Darboux algorithm.</returns>
    public override TNumber Approximate(SyncArgs<TNumber> args)
    {
        var sum = TNumber.Zero;
        var startAdjusted = args.start + args.step;

        for (var i = startAdjusted; i <= args.end; i += args.step)
        {
            sum +=
                Step(
                    this.func,
                    args.mode == IntegralDarbouxMode.Lower
                        ? i - args.step
                        : i,
                    args.step);
        }

        return sum;
    }

    /// <summary>
    /// Calculates an approximation of the integral using the Darboux algorithm.
    /// </summary>
    /// <param name="args">The arguments for an asynchronous Darboux approximation of the integral.</param>
    /// <param name="cancellationToken">A cancellation token.</param>
    /// <returns>The approximation of the integral with the Darboux algorithm.</returns>
    public override async Task<TNumber> ApproximateAsync(
        AsyncArgs<TNumber> args,
        CancellationToken cancellationToken = default)
    {
        if (args.partitions.Length == 0)
            throw new ArgumentOutOfRangeException(nameof(args.partitions), args.partitions, "Number of paritions must be greater than zero.");

        var sum = TNumber.Zero;

        var tasks = new Task<TNumber>[args.partitions.Length];
        for (var i = 0; i < tasks.Length; i++)
        {
            var state =
                new ThreadState(
                    this.func,
                    args.partitions.Span[i].start,
                    args.partitions.Span[i].end,
                    args.step,
                    args.mode,
                    cancellationToken);
            tasks[i] = Task.Factory.StartNew(DarbouxPerformThread, state, cancellationToken);
        }
        await Task.WhenAll(tasks);

        for (var i = 0; i < tasks.Length; i++)
        {
            sum += tasks[i].Result;
        }

        return sum;
    }
}
