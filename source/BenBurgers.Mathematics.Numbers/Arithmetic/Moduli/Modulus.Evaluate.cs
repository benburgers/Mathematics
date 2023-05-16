/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic.Sequence;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Moduli;

public readonly partial struct Modulus<TDividend, TDivisor>
{
    /// <inheritdoc/>
    public TResult Evaluate<TResult>(ArithmeticOptions options)
    {
        var numberTypeConverter = new NumberTypeConverter();
        var numberClass = (NumberClass)Math.Max((uint)this.Dividend.NumberClass, (uint)this.Divisor.NumberClass);
        if (numberClass.HasFlag(NumberClass.Integer))
        {
            var sequence =
                SequenceArithmetic.ModulusInteger(
                    this.Dividend.Sequence,
                    this.Divisor.Sequence,
                    options);
            var integer = new IntegerNumber(sequence, isNegative: false); // TODO isNegative?
            var result = numberTypeConverter.ConvertTo(integer, typeof(TResult));
            if (result is null)
                throw new NumberTypeNotSupportedException(typeof(TResult));
            return (TResult)result;
        }
        throw new NumberTypeNotSupportedException(typeof(TResult));
    }

    /// <inheritdoc/>
    public async Task<TResult> EvaluateAsync<TResult>(
        ArithmeticOptions options,
        CancellationToken cancellationToken = default)
    {
        var numberTypeConverter = new NumberTypeConverter();
        var numberClass = (NumberClass)Math.Max((uint)this.Dividend.NumberClass, (uint)this.Divisor.NumberClass);
        if (numberClass.HasFlag(NumberClass.Integer))
        {
            var sequence =
                await SequenceArithmetic.ModulusIntegerAsync(
                    this.Dividend.Sequence,
                    this.Divisor.Sequence,
                    options,
                    cancellationToken);
            var integer = new IntegerNumber(sequence, isNegative: false); // TODO isNegative?
            var result = numberTypeConverter.ConvertTo(integer, typeof(TResult));
            if (result is null)
                throw new NumberTypeNotSupportedException(typeof(TResult));
            return (TResult)result;
        }
        throw new NumberTypeNotSupportedException(typeof(TResult));
    }
}