/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetics;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Additions;

/// <summary>
/// An addition arithmetic operation.
/// </summary>
/// <typeparam name="TLeft">
/// The type of number as the left operand of the addition.
/// </typeparam>
/// <typeparam name="TRight">
/// The type of number as the right operand of the addition.
/// </typeparam>
public interface IAddition<TLeft, TRight>
    : IArithmeticOperation<ArithmeticOptions>
    where TLeft : struct, INumber<TLeft>
    where TRight : struct, INumber<TRight>
{
}