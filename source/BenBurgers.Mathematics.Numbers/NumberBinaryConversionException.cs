/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Resources;

namespace BenBurgers.Mathematics.Numbers;

/// <summary>
/// An exception that is thrown if converting a number from a binary representation failed.
/// </summary>
public class NumberBinaryConversionException
    : NumbersException
{
    /// <summary>
    /// Initializes a new instance of <see cref="NumberBinaryConversionException" />.
    /// </summary>
    public NumberBinaryConversionException()
        : base(ExceptionMessages.NumberBinaryConversionFailed)
    {
    }
}