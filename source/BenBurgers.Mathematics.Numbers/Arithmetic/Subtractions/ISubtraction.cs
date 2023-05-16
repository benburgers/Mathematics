/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetics;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Subtractions;

/// <summary>
/// A subtraction operation.
/// </summary>
/// <typeparam name="TLeft">
/// The number type of the left operand.
/// </typeparam>
/// <typeparam name="TRight">
/// The number type of the right operand.
/// </typeparam>
public interface ISubtraction<TLeft, TRight>
    : IArithmeticOperation<ArithmeticOptions>
    where TLeft : struct, INumber<TLeft>
    where TRight : struct, INumber<TRight>
{
    /// <summary>
    /// Gets the number to subtract from.
    /// </summary>
    TLeft Left { get; }

    /// <summary>
    /// Gets the number to subtract.
    /// </summary>
    TRight Right { get; }
}