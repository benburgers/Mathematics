/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Subtractions;

/// <summary>
/// A subtraction of a number from another number.
/// </summary>
/// <typeparam name="TLeft">
/// The type of number to subtract from.
/// </typeparam>
/// <typeparam name="TRight">
/// The type of number to subtract.
/// </typeparam>
public readonly partial struct Subtraction<TLeft, TRight>
    : ISubtraction<TLeft, TRight>
    where TLeft : struct, INumber<TLeft>
    where TRight : struct, INumber<TRight>
{
    /// <summary>
    /// Initializes a new instance of <see cref="Subtraction{TLeft, TRight}" />.
    /// </summary>
    /// <param name="left">
    /// The number to subtract from.
    /// </param>
    /// <param name="right">
    /// The number to subtract.
    /// </param>
    public Subtraction(TLeft left, TRight right)
    {
        Left = left;
        Right = right;
    }

    /// <inheritdoc />
    public TLeft Left { get; }

    /// <inheritdoc />
    public TRight Right { get; }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{this.Left} - {this.Right}";
    }
}