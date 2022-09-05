/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Additions;

/// <summary>
/// An addition of two numbers.
/// </summary>
/// <typeparam name="TLeft">
/// The type of the number to add to.
/// </typeparam>
/// <typeparam name="TRight">
/// The type of the number to add.
/// </typeparam>
public readonly partial struct Addition<TLeft, TRight>
    : IAddition<TLeft, TRight>
    where TLeft : struct, INumber<TLeft>
    where TRight : struct, INumber<TRight>
{
    /// <summary>
    /// Initializes a new instance of <see cref="Addition{TLeft, TRight}" />.
    /// </summary>
    /// <param name="left">
    /// The number to add to.
    /// </param>
    /// <param name="right">
    /// The number to add.
    /// </param>
    public Addition(TLeft left, TRight right)
    {
        this.Left = left;
        this.Right = right;
    }

    /// <summary>
    /// Gets the number to add to.
    /// </summary>
    public TLeft Left { get; }

    /// <summary>
    /// Gets the number to add.
    /// </summary>
    public TRight Right { get; }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{this.Left} + {this.Right}";
    }
}