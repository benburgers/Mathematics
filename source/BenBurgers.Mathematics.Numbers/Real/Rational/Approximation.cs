/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Sequence;

namespace BenBurgers.Mathematics.Numbers.Real.Rational;

/// <summary>
/// An approximation of a real number.
/// </summary>
public readonly partial struct Approximation
    : IApproximation<Approximation>
{
    /// <summary>
    /// Initializes a new instance of <see cref="Approximation" />.
    /// </summary>
    /// <param name="mantissa">
    /// The mantissa of the approximation.
    /// </param>
    /// <param name="scale">
    /// The scale of the approximation.
    /// </param>
    internal Approximation(NumberSequence mantissa, NumberSequence scale)
    {
        this.Mantissa = mantissa;
        this.Scale = scale;
    }

    /// <inheritdoc />
    public bool IsNegative => throw new NotImplementedException();

    /// <inheritdoc />
    public bool IsZero => throw new NotImplementedException();

    /// <inheritdoc />
    public NumberClass NumberClass => NumberClass.Real | NumberClass.Rational;

    /// <inheritdoc />
    internal NumberSequence Mantissa { get; }

    /// <inheritdoc />
    internal NumberSequence Scale { get; }

    NumberSequence IApproximation.Mantissa => this.Mantissa;

    NumberSequence IApproximation.Scale => this.Scale;
}