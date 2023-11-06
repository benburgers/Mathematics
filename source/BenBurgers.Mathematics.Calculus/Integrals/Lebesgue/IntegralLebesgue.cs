/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using System.Numerics;

namespace BenBurgers.Mathematics.Calculus.Integrals.Lebesgue;

/// <summary>
/// A Lebesgue integral.
/// </summary>
/// <typeparam name="TNumber">The type of number in the domain and range of the integral's function.</typeparam>
/// <remarks>
///     <a href="https://en.wikipedia.org/wiki/Lebesgue_integration">Lebesgue integral (Wikipedia)</a>
/// </remarks>
public sealed partial class IntegralLebesgue<TNumber> : Integral<TNumber, SyncArgs<TNumber>, AsyncArgs<TNumber>>
    where TNumber : INumber<TNumber>
{
    /// <summary>
    /// Initializes a new instance of <see cref="IntegralLebesgue{TNumber}" />.
    /// </summary>
    /// <param name="func">The integrated function.</param>
    public IntegralLebesgue(Integral<TNumber>.IntegralFunction func)
        : base(func)
    {
    }

    /// <inheritdoc/>
    public override TNumber Approximate(SyncArgs<TNumber> args)
    {
        var sum = TNumber.Zero;

        // Order target values for efficiency.
        var targetValues = new Memory<TNumber>(new TNumber[args.targetValues.Length]);
        args.targetValues.CopyTo(targetValues);
        targetValues.Span.Sort();

        // TODO determine ranges between target values
        // TODO calculate function outputs from start to end using step as interval
        // TODO whilst calculating function outputs, determine which domain values correspond to which range between target values
        // TODO sum the areas found in the previous step

        return sum;
    }

    /// <inheritdoc/>
    public override Task<TNumber> ApproximateAsync(
        AsyncArgs<TNumber> args,
        CancellationToken cancellationToken = default)
    {
        var sum = TNumber.Zero;

        // TODO assign the ranges between target values to threads
        // TODO each thread finds the areas for their assigned target value range
        // TODO sum the results of the threads

        throw new NotImplementedException();
    }
}
