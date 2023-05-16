/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Divisions;

/// <summary>
/// A division of one number by another.
/// </summary>
/// <typeparam name="TNumerator">
/// The type of the numerator.
/// </typeparam>
/// <typeparam name="TDenominator">
/// The type of the denominator.
/// </typeparam>
public partial struct Division<TNumerator, TDenominator>
    : IDivision<TNumerator, TDenominator>
    where TNumerator : INumber<TNumerator>
    where TDenominator : INumber<TDenominator>
{
    /// <summary>
    /// Initializes a new instance of <see cref="Division{TLeft, TRight}" />.
    /// </summary>
    /// <param name="numerator">
    /// The numerator.
    /// </param>
    /// <param name="denominator">
    /// The denominator.
    /// </param>
    public Division(TNumerator numerator, TDenominator denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    /// <inheritdoc />
    public TNumerator Numerator { get; }

    /// <inheritdoc />
    public TDenominator Denominator { get; }

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
        var resultType = typeof(TResult);
        if (resultType.IsGenericType)
            resultType = resultType.GetGenericTypeDefinition();
        if (!Evaluators.TryGetValue(resultType, out var evaluator))
            throw new NumberTypeNotSupportedException(typeof(TResult));
        var evaluation = await evaluator(this);
        if (evaluation is not TResult { } result)
            throw new ArithmeticEvaluationFailedException(typeof(TResult));
        return result;
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{this.Numerator} / {this.Denominator}";
    }
}