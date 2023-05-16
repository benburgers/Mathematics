/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers;

/// <summary>
/// A class of numbers.
/// </summary>
public enum NumberClass : uint
{
    /// <summary>
    /// The prime numbers (ℙ).
    /// </summary>
    Prime = 0b0000_0000_0000_0001,

    /// <summary>
    /// The natural numbers (ℕ).
    /// </summary>
    Natural = 0b0000_0000_0000_0010,

    /// <summary>
    /// The integers (ℤ). 
    /// </summary>
    Integer = 0b0000_0000_0000_0100,

    /// <summary>
    /// The rational numbers (ℚ).
    /// </summary>
    Rational = 0b0000_0000_0000_1000,

    /// <summary>
    /// The real numbers (ℝ).
    /// </summary>
    Real = 0b0000_0000_0001_0000,

    /// <summary>
    /// The irrational numbers (ℙ).
    /// </summary>
    IrrationalNumbers = 0b0000_0000_0010_0000,

    /// <summary>
    /// The imaginary numbers (𝕀).
    /// </summary>
    ImaginaryNumbers = 0b0000_0000_0100_0000,

    /// <summary>
    /// The complex numbers (ℂ).
    /// </summary>
    ComplexNumbers = 0b0000_0000_1000_0000,

    /// <summary>
    /// The hypercomplex numbers.
    /// </summary>
    HypercomplexNumbers = 0b0000_0001_0000_0000,

    /// <summary>
    /// The pAdic numbers.
    /// </summary>
    PAdicNumbers = 0b0000_0010_0000_0000
}