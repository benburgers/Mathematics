/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using System.Numerics;

namespace BenBurgers.Mathematics.Calculus.Integrals;

/// <summary>
/// Calculates integrals.
/// </summary>
public abstract class Integral
{
}

/// <summary>
/// Calculates integrals.
/// </summary>
/// <typeparam name="TNumber">The type of number in the function's domain and range.</typeparam>
public abstract class Integral<TNumber> : Integral
    where TNumber : INumber<TNumber>
{
    /// <summary>
    /// A partition of an integral's approximation.
    /// </summary>
    public readonly struct Partition
    {
        /// <summary>
        /// The start of the partition.
        /// </summary>
        public readonly TNumber start;

        /// <summary>
        /// The end of the partition.
        /// </summary>
        public readonly TNumber end;

        /// <summary>
        /// Initializes a new instance of <see cref="Partition" />.
        /// </summary>
        /// <param name="start">The start of the partition.</param>
        /// <param name="end">The end of the partition.</param>
        public Partition(TNumber start, TNumber end)
        {
            this.start = start;
            this.end = end;
        }
    }

    /// <summary>
    /// A delegate for an integral function.
    /// </summary>
    /// <param name="input">The input of the function.</param>
    /// <returns>The output of the function.</returns>
    public delegate TNumber IntegralFunction(TNumber input);
}


/// <summary>
/// Represents an integral of a function.
/// </summary>
/// <typeparam name="TNumber">The type of number in the function's domain and range.</typeparam>
/// <typeparam name="TApproximationArgs">The type of arguments for synchronously calculating the approximation of the integral.</typeparam>
/// <typeparam name="TApproximationAsyncArgs">The type of arguments for asynchronously calculating the approximation of the integral.</typeparam>
public abstract class Integral<TNumber, TApproximationArgs, TApproximationAsyncArgs> : Integral
    where TNumber : INumber<TNumber>
{
    /// <summary>
    /// The function that is integrated.
    /// </summary>
    protected readonly Integral<TNumber>.IntegralFunction func;

    /// <summary>
    /// Initializes a new instance of <see cref="Integral" />.
    /// </summary>
    /// <param name="func">The integral's function.</param>
    public Integral(Integral<TNumber>.IntegralFunction func)
    {
        this.func = func;
    }

    /// <summary>
    /// Calculates the approximation of the integral.
    /// </summary>
    /// <param name="args">Arguments for the synchronous approximation of the integral.</param>
    /// <returns>The approximation of the integral.</returns>
    public abstract TNumber Approximate(TApproximationArgs args);

    /// <summary>
    /// Asynchronously calculates the approximation of the integral.
    /// </summary>
    /// <param name="args">Arguments for the asynchronous approximation of the integral.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The approximation of the integral.</returns>
    public abstract Task<TNumber> ApproximateAsync(TApproximationAsyncArgs args, CancellationToken cancellationToken = default);
}