/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers.Imaginary;

/// <summary>
/// Represents an imaginary number.
/// </summary>
/// <typeparam name="TSelf">
/// The type of imaginary number.
/// </typeparam>
public interface IImaginaryNumber<TSelf>
    : INumber<TSelf>
    where TSelf : IImaginaryNumber<TSelf>
{
}