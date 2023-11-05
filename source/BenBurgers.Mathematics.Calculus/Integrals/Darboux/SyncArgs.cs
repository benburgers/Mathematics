/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using System.Numerics;

namespace BenBurgers.Mathematics.Calculus.Integrals.Darboux;

/// <summary>
/// Arguments for a synchronous Darboux approximation of an integral.
/// </summary>
/// <typeparam name="TNumber">The type of number in the function's domain and range.</typeparam>
public readonly struct SyncArgs<TNumber>
    where TNumber : INumber<TNumber>
{
    /// <summary>
    /// The start of the integral approximation.
    /// </summary>
    public readonly TNumber start;

    /// <summary>
    /// The end of the integral approximation.
    /// </summary>
    public readonly TNumber end;

    /// <summary>
    /// The step of the integral approximation.
    /// </summary>
    public readonly TNumber step;

    /// <summary>
    /// The mode of the Darboux algorithm.
    /// </summary>
    public readonly IntegralDarbouxMode mode;

    /// <summary>
    /// Initializes a new instance of <see cref="SyncArgs{TNumber}" />.
    /// </summary>
    /// <param name="start">The start of the integral approximation.</param>
    /// <param name="end">The end of the integral approximation.</param>
    /// <param name="step">The step of the integral approximation.</param>
    /// <param name="mode">The mode of the Darboux algorithm.</param>
    public SyncArgs(
        TNumber start,
        TNumber end,
        TNumber step,
        IntegralDarbouxMode mode)
    {
        this.start = start;
        this.end = end;
        this.step = step;
        this.mode = mode;
    }
}
