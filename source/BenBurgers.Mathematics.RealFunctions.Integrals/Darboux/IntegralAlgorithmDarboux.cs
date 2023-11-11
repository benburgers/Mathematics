/*
 * This file is part of Ben Burgers Mathematics.
 * 
 * Ben Burgers Mathematics is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License 
 * as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
 * 
 * Ben Burgers Mathematics is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
 * without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 * See the GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License along with Foobar. If not, see <https://www.gnu.org/licenses/>.
 */

using System.Diagnostics;
using System.Numerics;

namespace BenBurgers.Mathematics.RealFunctions.Integrals.Darboux;

/// <summary>
/// The Riemann-Darboux algorithm for the approximation of an integral of a real function.
/// </summary>
/// <typeparam name="TNumber">The type of number in the integral's number space.</typeparam>
public sealed partial class IntegralAlgorithmDarboux<TNumber> : IIntegralAlgorithm<TNumber, IDarbouxArgsSync<TNumber>, DarbouxArgsAsync<TNumber>>
    where TNumber : INumber<TNumber>
{
    /// <summary>
    /// Initializes a new instance of <see cref="IntegralAlgorithmDarboux{TNumber}" />.
    /// </summary>
    /// <param name="function">The function that is integrated.</param>
    public IntegralAlgorithmDarboux(Integral<TNumber>.IntegralFunction function)
    {
        this.Function = function;
    }

    /// <inheritdoc/>
    public Integral<TNumber>.IntegralFunction Function { get; }

    private static TNumber Infimum(TNumber one, TNumber other)
    {
        return (one, other) switch
        {
            (_, _) when one <= TNumber.Zero && other <= TNumber.Zero => TNumber.Max(one, other),
            (_, _) when one > TNumber.Zero && other < TNumber.Zero => other,
            (_, _) when one < TNumber.Zero && other > TNumber.Zero => one,
            (_, _) when one >= TNumber.Zero && other >= TNumber.Zero => TNumber.Min(one, other),
            _ => throw new UnreachableException()
        };
    }

    private static TNumber Supremum(TNumber one, TNumber other)
    {
        return (one, other) switch
        {
            (_, _) when one <= TNumber.Zero && other <= TNumber.Zero => TNumber.Min(one, other),
            (_, _) when one > TNumber.Zero && other < TNumber.Zero => one,
            (_, _) when one < TNumber.Zero && other > TNumber.Zero => other,
            (_, _) when one >= TNumber.Zero && other >= TNumber.Zero => TNumber.Max(one, other),
            _ => throw new UnreachableException()
        };
    }

    private static TNumber PerformIntervals(
        Integral<TNumber>.IntegralFunction function,
        DarbouxIntervalsArgsSync<TNumber> args)
    {
        if (args.Intervals.Length == 0)
            return TNumber.Zero;
        if (args.Intervals.Length == 1)
            return function(args.Intervals.Span[0]);

        var sum = TNumber.Zero;
        var intervals = args.Intervals.Span;

        // initialize working values
        var values = new Span<TNumber>(
            new TNumber[]
            {
                intervals[0],
                function(intervals[0]),
                intervals[1],
                function(intervals[1])
            });

        for (var i = 0; i < intervals.Length; i++)
        {
            sum +=
                (args.Mode == IntegralDarbouxMode.Lower
                    ? Infimum(values[1], values[3])
                    : Supremum(values[1], values[3]))
                    * (values[2] - values[0]);

            values[0] = values[2];
            values[1] = values[3];
            values[2] = intervals[i];
            values[3] = function(values[2]);
        }

        return sum;
    }
    private static TNumber PerformSteps(Integral<TNumber>.IntegralFunction function, DarbouxStepArgsSync<TNumber> args)
    {
        var startFromStep = args.start + args.step;
        if (startFromStep > args.end)
            return TNumber.Zero; // TODO calculate args.end - args.start as only integral partition

        var mode = args.Mode;
        var sum = TNumber.Zero;
        var values =
            new Span<TNumber>(
                new TNumber[]
                {
                    function(args.start), // f(xᵢ₋₁)
                    function(startFromStep) // f(xᵢ)
                });

        for (var i = startFromStep; i <= args.end; i += args.step)
        {
            sum +=
                (mode == IntegralDarbouxMode.Lower
                    ? Infimum(values[0], values[1])
                    : Supremum(values[0], values[1]))
                    * args.step;
            values[0] = values[1]; // f(xᵢ₋₁)
            values[1] = function(i + args.step); // f(xᵢ)
        }

        return sum;
    }

    private static TNumber PerformThread(object? state)
    {
        if (state is not ThreadState { } threadState)
            throw new ArgumentException(null, nameof(state));

        return PerformSteps(
            threadState.function,
            new DarbouxStepArgsSync<TNumber>(threadState.start, threadState.end, threadState.step, threadState.mode));
    }

    /// <inheritdoc/>
    public TNumber Approximate(IDarbouxArgsSync<TNumber> args)
    {
        return args switch
        {
            DarbouxIntervalsArgsSync<TNumber> intervalsArgs => PerformIntervals(this.Function, intervalsArgs),
            DarbouxStepArgsSync<TNumber> stepArgs => PerformSteps(this.Function, stepArgs),
            _ => throw new ArgumentException(null, nameof(args)),
        };
    }

    /// <inheritdoc/>
    public async Task<TNumber> ApproximateAsync(DarbouxArgsAsync<TNumber> args, CancellationToken cancellationToken = default)
    {
        if (args.partitions.Length == 0)
            throw new ArgumentOutOfRangeException(nameof(args.partitions), args.partitions, "Number of partitions must be greater than zero.");

        var sum = TNumber.Zero;

        var tasks = new Task<TNumber>[args.partitions.Length];
        for (var i = 0; i < tasks.Length; i++)
        {
            var state =
                new ThreadState(
                    this.Function,
                    args.partitions.Span[i].start,
                    args.partitions.Span[i].end,
                    args.step,
                    args.mode,
                    cancellationToken);
            tasks[i] = Task.Factory.StartNew(PerformThread, state, cancellationToken);
        }
        await Task.WhenAll(tasks);

        for (var i = 0; i < tasks.Length; i++)
        {
            sum += tasks[i].Result;
        }

        return sum;
    }
}
