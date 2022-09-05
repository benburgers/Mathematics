/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetics;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Multiplications;

/// <summary>
/// Represents a multiplication of two numbers.
/// </summary>
/// <typeparam name="TLeft">
/// The type of number of the left operand.
/// </typeparam>
/// <typeparam name="TRight">
/// The type of number of the right operand.
/// </typeparam>
public interface IMultiplication<TLeft, TRight>
    : IArithmeticOperation<ArithmeticOptions>
    where TLeft : INumber<TLeft>
    where TRight : INumber<TRight>
{
    /// <summary>
    /// Gets the left operand of the multiplication.
    /// </summary>
    TLeft Left { get; }

    /// <summary>
    /// Gets the right operand of the multiplication.
    /// </summary>
    TRight Right { get; }
}