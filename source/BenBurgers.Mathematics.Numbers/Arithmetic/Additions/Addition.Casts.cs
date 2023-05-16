/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Additions;

public readonly partial struct Addition<TLeft, TRight>
{
    /// <summary>
    /// Evaluates the addition to a <see cref="byte" />.
    /// </summary>
    /// <param name="addition">
    /// The addition arithmetic operation to evaluate.
    /// </param>
    public static explicit operator byte(Addition<TLeft, TRight> addition)
        => (byte)addition
            .EvaluateAsync<NaturalNumber>(ArithmeticOptions.Default)
            .ConfigureAwait(false)
            .GetAwaiter()
            .GetResult();

    /// <summary>
    /// Evaluates the addition to a <see cref="sbyte" />.
    /// </summary>
    /// <param name="addition">
    /// The addition arithmetic operation to evaluate.
    /// </param>
    public static explicit operator sbyte(Addition<TLeft, TRight> addition)
        => (sbyte)addition
            .EvaluateAsync<IntegerNumber>(ArithmeticOptions.Default)
            .ConfigureAwait(false)
            .GetAwaiter()
            .GetResult();

    /// <summary>
    /// Evaluates the addition to a <see cref="ushort" />.
    /// </summary>
    /// <param name="addition">
    /// The addition arithmetic operation to evaluate.
    /// </param>
    public static explicit operator ushort(Addition<TLeft, TRight> addition)
        => (ushort)addition
            .EvaluateAsync<NaturalNumber>(ArithmeticOptions.Default)
            .ConfigureAwait(false)
            .GetAwaiter()
            .GetResult();

    /// <summary>
    /// Evaluates the addition to a <see cref="short" />.
    /// </summary>
    /// <param name="addition">
    /// The addition arithmetic operation to evaluate.
    /// </param>
    public static explicit operator short(Addition<TLeft, TRight> addition)
        => (short)addition
            .EvaluateAsync<IntegerNumber>(ArithmeticOptions.Default)
            .ConfigureAwait(false)
            .GetAwaiter()
            .GetResult();

    /// <summary>
    /// Evaluates the addition to a <see cref="uint" />.
    /// </summary>
    /// <param name="addition">
    /// The addition arithmetic operation to evaluate.
    /// </param>
    public static explicit operator uint(Addition<TLeft, TRight> addition)
        => (uint)addition
            .EvaluateAsync<NaturalNumber>(ArithmeticOptions.Default)
            .ConfigureAwait(false)
            .GetAwaiter()
            .GetResult();

    /// <summary>
    /// Evaluates the addition to an <see cref="int" />.
    /// </summary>
    /// <param name="addition">
    /// The addition arithmetic operation to evaluate.
    /// </param>
    public static explicit operator int(Addition<TLeft, TRight> addition)
        => (int)addition
            .EvaluateAsync<IntegerNumber>(ArithmeticOptions.Default)
            .ConfigureAwait(false)
            .GetAwaiter()
            .GetResult();

    /// <summary>
    /// Evaluates the addition to an <see cref="ulong" />.
    /// </summary>
    /// <param name="addition">
    /// The addition arithmetic operation to evaluate.
    /// </param>
    public static explicit operator ulong(Addition<TLeft, TRight> addition)
        => (ulong)addition
            .EvaluateAsync<NaturalNumber>(ArithmeticOptions.Default)
            .ConfigureAwait(false)
            .GetAwaiter()
            .GetResult();

    /// <summary>
    /// Evaluates the addition to a <see cref="long" />.
    /// </summary>
    /// <param name="addition">
    /// The addition arithmetic operation to evaluate.
    /// </param>
    public static explicit operator long(Addition<TLeft, TRight> addition)
        => (long)addition
            .EvaluateAsync<IntegerNumber>(ArithmeticOptions.Default)
            .ConfigureAwait(false)
            .GetAwaiter()
            .GetResult();
}