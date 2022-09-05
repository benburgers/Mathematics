/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic.Sequence;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Additions;

public readonly partial struct Addition<TLeft, TRight>
{
    /// <inheritdoc />
    public TResult Evaluate<TResult>(ArithmeticOptions options)
        => this
            .EvaluateAsync<TResult>(options)
            .ConfigureAwait(false)
            .GetAwaiter()
            .GetResult();

    /// <inheritdoc />
    public async Task<TResult> EvaluateAsync<TResult>(
        ArithmeticOptions options,
        CancellationToken cancellationToken = default)
    {
        var leftNumberClass = (uint)this.Left.NumberClass;
        var rightNumberClass = (uint)this.Right.NumberClass;
        var maxNumberClass = (NumberClass)Math.Max(leftNumberClass, rightNumberClass);

        if (maxNumberClass.HasFlag(NumberClass.Integer))
        {
            var leftInteger = (IIntegerNumber)this.Left;
            var rightInteger = (IIntegerNumber)this.Right;
            var addition =
                await SequenceArithmetic.AddIntegerAsync(
                    leftInteger.Sequence,
                    leftInteger.IsNegative,
                    rightInteger.Sequence,
                    rightInteger.IsNegative,
                    options,
                    cancellationToken);
            var typeConverter = new NumberTypeConverter();
            var conversion = typeConverter.ConvertTo(addition, typeof(TResult));
            if (conversion is null)
                throw new NumberTypeNotSupportedException(typeof(TResult));
            return (TResult)conversion;
        }

        throw new AggregateException(new NumberTypeNotSupportedException(typeof(TLeft)), new NumberTypeNotSupportedException(typeof(TRight)));
    }
}
