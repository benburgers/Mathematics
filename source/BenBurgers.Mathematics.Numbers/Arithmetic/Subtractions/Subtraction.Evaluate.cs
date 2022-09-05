/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic.Sequence;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Subtractions;

public readonly partial struct Subtraction<TLeft, TRight>
{
    /// <inheritdoc />
    public TResult Evaluate<TResult>(ArithmeticOptions options)
    {
        return
            this
                .EvaluateAsync<TResult>(options)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
    }

    /// <inheritdoc />
    public async Task<TResult> EvaluateAsync<TResult>(
        ArithmeticOptions options,
        CancellationToken cancellationToken = default)
    {
        var numberTypeConverter = new NumberTypeConverter();
        var numberClass = (NumberClass)Math.Max((uint)this.Left.NumberClass, (uint)this.Right.NumberClass);
        if (numberClass.HasFlag(NumberClass.Integer))
        {
            var integer = // add but switch sign of right operand
                await SequenceArithmetic.AddIntegerAsync(
                    ((IIntegerNumber)this.Left).Sequence,
                    this.Left.IsNegative,
                    ((IIntegerNumber)this.Right).Sequence,
                    !this.Right.IsNegative,
                    options,
                    cancellationToken);
            return (TResult)numberTypeConverter.ConvertTo(integer, typeof(TResult))!;
        }
        throw new NumberTypeNotSupportedException(typeof(TResult));
    }
}