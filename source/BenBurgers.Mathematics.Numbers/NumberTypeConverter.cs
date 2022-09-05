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
using System.ComponentModel;
using System.Globalization;

namespace BenBurgers.Mathematics.Numbers;

internal class NumberTypeConverter : TypeConverter
{
    private static bool IsFraction(Type type)
        => type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Fraction<,>);

    /// <inheritdoc />
    public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
    {
        return sourceType switch
        {
            Type t when t == typeof(PrimeNumber) => true,
            Type t when t == typeof(NaturalNumber) => true,
            Type t when t == typeof(IntegerNumber) => true,
            Type t when IsFraction(t) => false, // TODO not yet
            Type t when t == typeof(Pi) => true, // TODO not yet
            _ => base.CanConvertFrom(context, sourceType)
        };
    }

    /// <inheritdoc />
    public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
    {
        return destinationType switch
        {
            Type t when t == typeof(PrimeNumber) => true,
            Type t when t == typeof(NaturalNumber) => true,
            Type t when t == typeof(IntegerNumber) => true,
            Type t when IsFraction(t) => false, // TODO not yet
            Type t when t == typeof(Pi) => false, // TODO not yet
            _ => base.CanConvertTo(context, destinationType)
        };
    }

    /// <inheritdoc />
    public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
    {
        return base.ConvertFrom(context, culture, value);
    }

    /// <inheritdoc />
    public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
    {
        return value switch
        {
            PrimeNumber prime => destinationType switch
            {
                Type t when t == typeof(PrimeNumber) => prime,
                Type t when t == typeof(NaturalNumber) => (NaturalNumber)prime,
                Type t when t == typeof(IntegerNumber) => (IntegerNumber)prime,
                Type t when IsFraction(t) => throw new NumberTypeNotSupportedException(t), // not yet
                Type t when t == typeof(Pi) => throw new NumberTypeNotSupportedException(t), // not yet
                _ => base.ConvertTo(context, culture, value, destinationType)
            },
            NaturalNumber natural => destinationType switch
            {
                Type t when t == typeof(PrimeNumber) => (PrimeNumber)natural,
                Type t when t == typeof(NaturalNumber) => natural,
                Type t when t == typeof(IntegerNumber) => (IntegerNumber)natural,
                Type t when IsFraction(t) => throw new NumberTypeNotSupportedException(t), // not yet
                Type t when t == typeof(Pi) => throw new NumberTypeNotSupportedException(t), // not yet
                _ => base.ConvertTo(context, culture, value, destinationType)
            },
            IntegerNumber integer => destinationType switch
            {
                Type t when t == typeof(PrimeNumber) => (PrimeNumber)integer,
                Type t when t == typeof(NaturalNumber) => (NaturalNumber)integer,
                Type t when t == typeof(IntegerNumber) => integer,
                Type t when IsFraction(t) => throw new NumberTypeNotSupportedException(t), // not yet
                Type t when t == typeof(Pi) => throw new NumberTypeNotSupportedException(t), // not yet
                _ => base.ConvertTo(context, culture, value, destinationType)
            },
            _ => base.ConvertTo(context, culture, value, destinationType)
        };
    }
}