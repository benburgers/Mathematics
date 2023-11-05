/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using System.Numerics;

namespace BenBurgers.Mathematics.Calculus.Integrals.Darboux;

/// <summary>
/// Arguments for an asynchronous Darboux approximation of an integral.
/// </summary>
public readonly struct AsyncArgs<TNumber>
    where TNumber : INumber<TNumber>
{
    /// <summary>
    /// The partitions of the integral to divide among threads.
    /// </summary>
    public readonly ReadOnlyMemory<Integral<TNumber>.Partition> partitions;

    /// <summary>
    /// The step of the Darboux integral.
    /// </summary>
    public readonly TNumber step;

    /// <summary>
    /// The mode of the Darboux integral approximation algorithm.
    /// </summary>
    public readonly IntegralDarbouxMode mode;

    /// <summary>
    /// Initializes a new instance of <see cref="AsyncArgs{TNumber}" />.
    /// </summary>
    /// <param name="partitions">The partitions of the integral to divide among threads.</param>
    /// <param name="step">The step of the Darboux integral.</param>
    /// <param name="mode">The mode of the Darboux integral approximation algorithm.</param>
    public AsyncArgs(
        ReadOnlyMemory<Integral<TNumber>.Partition> partitions,
        TNumber step,
        IntegralDarbouxMode mode)
    {
        this.partitions = partitions;
        this.step = step;
        this.mode = mode;
    }
}
