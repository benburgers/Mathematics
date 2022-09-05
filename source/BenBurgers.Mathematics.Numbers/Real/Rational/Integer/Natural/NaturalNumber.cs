/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic;
using BenBurgers.Mathematics.Numbers.Arithmetic.Sequence;
using BenBurgers.Mathematics.Numbers.Sequence;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

/// <summary>
/// Represents a natural number.
/// </summary>
public readonly partial struct NaturalNumber
    : INaturalNumber<NaturalNumber>
{
    internal readonly NumberSequence sequence;
    private readonly Lazy<bool> isEven;
    private readonly Lazy<bool> isZero;

    internal NaturalNumber(NumberSequence sequence)
    {
        this.sequence = sequence;
        this.isEven = new(() => (sequence.StartNode.Value & 0x1) == 0, LazyThreadSafetyMode.PublicationOnly);
        this.isZero = new(() => SequenceArithmetic.EvaluateIsZero(typeof(NaturalNumber), sequence, ArithmeticOptions.Default), LazyThreadSafetyMode.PublicationOnly);
    }

    /// <inheritdoc/>
    public bool IsEven => this.isEven.Value;

    /// <inheritdoc/>
    public bool IsNegative => false;

    /// <inheritdoc/>
    public bool IsZero => isZero.Value;

    /// <inheritdoc/>
    public NumberClass NumberClass =>
        NumberClass.Real
        | NumberClass.Rational
        | NumberClass.Integer
        | NumberClass.Natural;

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Parses a <see cref="NaturalNumber" /> from a <see cref="string" /> representation.
    /// </summary>
    /// <param name="naturalString">
    /// The <see cref="string" /> representation of a <see cref="NaturalNumber" />.
    /// </param>
    /// <param name="options">
    /// The options for arithmetic operations.
    /// </param>
    /// <returns>
    /// The parsed <see cref="NaturalNumber" />.
    /// </returns>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the operation exceeded the timeout.
    /// </exception>
    public static NaturalNumber Parse(
        string naturalString,
        ArithmeticOptions options)
    {
        var sequence = SequenceArithmetic.Parse(naturalString, options);
        return new(sequence);
    }

    /// <summary>
    /// Parses a <see cref="NaturalNumber" /> from a <see cref="string" /> representation.
    /// </summary>
    /// <param name="naturalString">
    /// The <see cref="string" /> representation of a <see cref="NaturalNumber" />.
    /// </param>
    /// <param name="options">
    /// The options for arithmetic operations.
    /// </param>
    /// <param name="cancellationToken">
    /// The cancellation token.
    /// </param>
    /// <returns>
    /// The parsed <see cref="NaturalNumber" />.
    /// </returns>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the operation exceeded the timeout.
    /// </exception>
    /// <exception cref="TaskCanceledException">
    /// A <see cref="TaskCanceledException" /> is thrown if the operation was canceled.
    /// </exception>
    public static async Task<NaturalNumber> ParseAsync(
        string naturalString,
        ArithmeticOptions options,
        CancellationToken cancellationToken = default)
    {
        var sequence = await SequenceArithmetic.ParseAsync(naturalString, options, cancellationToken);
        return new(sequence);
    }

    /// <summary>
    /// Returns a <see cref="string" /> representation of <see cref="NaturalNumber" />.
    /// </summary>
    /// <returns>
    /// The <see cref="string" /> representation of <see cref="NaturalNumber" />.
    /// </returns>
    public override string ToString()
        => SequenceArithmetic.ToString(
            typeof(NaturalNumber),
            this.sequence,
            ArithmeticOptions.Default);

    NumberSequence IIntegerNumber.Sequence => this.sequence;
}