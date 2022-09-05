/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers.Real.Rational;

/// <summary>
/// Represents a fraction with a numerator and a denominator.
/// </summary>
/// <typeparam name="TNumerator">
/// The type of the numerator.
/// </typeparam>
/// <typeparam name="TDenominator">
/// The type of the denominator.
/// </typeparam>
public readonly partial struct Fraction<TNumerator, TDenominator>
    : IFraction<TNumerator, TDenominator>,
    IRationalNumber<Fraction<TNumerator, TDenominator>>
    where TNumerator : INumber<TNumerator>
    where TDenominator : INumber<TDenominator>
{
    internal Fraction(TNumerator numerator, TDenominator denominator)
    {
        if (denominator.IsZero)
            throw new DivideByZeroException();
        this.Numerator = numerator;
        this.Denominator = denominator;
    }

    /// <summary>
    /// Gets the numerator.
    /// </summary>
    public TNumerator Numerator { get; }

    /// <summary>
    /// Gets the denominator.
    /// </summary>
    public TDenominator Denominator { get; }

    /// <inheritdoc />
    public bool IsZero => this.Numerator.IsZero;

    /// <inheritdoc />
    public bool IsNegative => this.Numerator.IsNegative ^ this.Denominator.IsNegative;

    /// <inheritdoc />
    public NumberClass NumberClass => NumberClass.Rational;

    /// <inheritdoc />
    public override int GetHashCode()
        => HashCode.Combine(this.Numerator.GetHashCode(), this.Denominator.GetHashCode());

    INumber IFraction.Numerator => this.Numerator;

    INumber IFraction.Denominator => this.Denominator;
}