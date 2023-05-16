/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic;
using BenBurgers.Mathematics.Numbers.Arithmetic.Sequence;
using BenBurgers.Mathematics.Numbers.Sequence;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer;

/// <summary>
/// Represents an integer number.
/// </summary>
public readonly partial struct IntegerNumber
    : IIntegerNumber<IntegerNumber>
{
    private readonly Lazy<bool> isEven;
    private readonly Lazy<bool> isZero;
    internal readonly NumberSequence sequence;
    internal readonly bool isNegative;

    internal IntegerNumber(
        NumberSequence sequence,
        bool isNegative)
    {
        this.sequence = sequence;
        this.isNegative = isNegative;
        this.isEven = new(() => (sequence.StartNode.Value & 0x1) == 0, LazyThreadSafetyMode.None);
        this.isZero = new(() => SequenceArithmetic.EvaluateIsZero(typeof(IntegerNumber), sequence, ArithmeticOptions.Default), LazyThreadSafetyMode.None);
    }

    /// <inheritdoc/>
    public bool IsEven => this.isEven.Value;

    /// <inheritdoc/>
    public bool IsNegative => this.isNegative;

    /// <inheritdoc/>
    public bool IsZero => this.isZero.Value;

    /// <inheritdoc/>
    public NumberClass NumberClass =>
        NumberClass.Real
        | NumberClass.Rational
        | NumberClass.Integer;

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return this.sequence.Start.GetHashCode();
    }

    NumberSequence IIntegerNumber.Sequence => this.sequence;
}
