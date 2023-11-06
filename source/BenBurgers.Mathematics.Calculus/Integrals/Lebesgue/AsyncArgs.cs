/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using System.Numerics;

namespace BenBurgers.Mathematics.Calculus.Integrals.Lebesgue;

/// <summary>
/// Arguments for an asynchronous Lebesgue approximation of an integral.
/// </summary>
/// <typeparam name="TNumber">The type of number in the domain and range of the integral's function.</typeparam>
public readonly struct AsyncArgs<TNumber>
    where TNumber : INumber<TNumber>
{
}
