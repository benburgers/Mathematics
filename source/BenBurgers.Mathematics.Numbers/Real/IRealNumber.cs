/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Irrational;
using BenBurgers.Mathematics.Numbers.Real.Rational;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural.Prime;

namespace BenBurgers.Mathematics.Numbers.Real;

/// <summary>
/// Represents a real number.
/// </summary>
public interface IRealNumber
    : INumber
{
}

/// <summary>
/// Represents a real number.
/// </summary>
/// <typeparam name="TNumber">The type of real number.</typeparam>
public interface IRealNumber<TNumber>
    : IRealNumber,
    INumber<TNumber>,
    IComparable<IPrimeNumber>,
    IComparable<INaturalNumber>,
    IComparable<IIntegerNumber>,
    IComparable<IRationalNumber>,
    IComparable<IIrrationalNumber>,
    IEquatable<IPrimeNumber>,
    IEquatable<INaturalNumber>,
    IEquatable<IIntegerNumber>,
    IEquatable<IRationalNumber>,
    IEquatable<IIrrationalNumber>
    where TNumber : IRealNumber<TNumber>
{
}