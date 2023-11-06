/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using System.Numerics;

namespace BenBurgers.Mathematics.Calculus.Integrals.Lebesgue;

/// <summary>
/// Arguments for a synchronous Lebesgue approximation of an integral.
/// </summary>
/// <typeparam name="TNumber">The type of number in the domain and range of the integral's function.</typeparam>
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
    /// The target values of the Lebesgue integral approximation.
    /// </summary>
    public readonly ReadOnlyMemory<TNumber> targetValues;

    /// <summary>
    /// Initializes a new instance of <see cref="SyncArgs{TNumber}" />.
    /// </summary>
    /// <param name="start">The start of the integral approximation.</param>
    /// <param name="end">The end of the integral approximation.</param>
    /// <param name="step">The step of the integral approximation.</param>
    /// <param name="targetValues">The target values of the Lebesgue integral approximation.</param>
    public SyncArgs(
        TNumber start,
        TNumber end,
        TNumber step,
        ReadOnlyMemory<TNumber> targetValues)
    {
        this.start = start;
        this.end = end;
        this.step = step;
        this.targetValues = targetValues;
    }
}
