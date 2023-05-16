/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

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
public struct Multiplication<TLeft, TRight>
    : IMultiplication<TLeft, TRight>
    where TLeft : INumber<TLeft>
    where TRight : INumber<TRight>
{
    internal Multiplication(TLeft left, TRight right)
    {
        Left = left;
        Right = right;
    }

    /// <inheritdoc/>
    public TLeft Left { get; init; }

    /// <inheritdoc/>
    public TRight Right { get; init; }

    /// <inheritdoc/>
    public TResult Evaluate<TResult>(ArithmeticOptions options)
    {
        return
            this
                .EvaluateAsync<TResult>(options)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
    }

    /// <inheritdoc/>
    public Task<TResult> EvaluateAsync<TResult>(
        ArithmeticOptions options,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}