/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Divisions;

public partial struct Division<TNumerator, TDenominator>
{
    private static readonly IReadOnlyDictionary<Type, Func<Division<TNumerator, TDenominator>, Task<object?>>> Evaluators =
        new Dictionary<Type, Func<Division<TNumerator, TDenominator>, Task<object?>>>
        {
            { typeof(byte), EvaluateAsUnsignedByte },
            { typeof(sbyte), EvaluateAsSignedByte },
            { typeof(ushort), EvaluateAsUnsignedInteger16 },
            { typeof(short), EvaluateAsSignedInteger16 },
            { typeof(uint), EvaluateAsUnsignedInteger32 },
            { typeof(int), EvaluateAsSignedInteger32 },
            { typeof(ulong), EvaluateAsUnsignedInteger64 },
            { typeof(long), EvaluateAsSignedInteger64 },
            { typeof(Fraction<,>), EvaluateAsFraction }
        };

    private static Task<object?> EvaluateAsUnsignedByte(Division<TNumerator, TDenominator> division)
    {
        throw new NotImplementedException();
    }

    private static Task<object?> EvaluateAsSignedByte(Division<TNumerator, TDenominator> division)
    {
        throw new NotImplementedException();
    }

    private static Task<object?> EvaluateAsUnsignedInteger16(Division<TNumerator, TDenominator> division)
    {
        throw new NotImplementedException();
    }

    private static Task<object?> EvaluateAsSignedInteger16(Division<TNumerator, TDenominator> division)
    {
        throw new NotImplementedException();
    }

    private static Task<object?> EvaluateAsUnsignedInteger32(Division<TNumerator, TDenominator> division)
    {
        throw new NotImplementedException();
    }

    private static Task<object?> EvaluateAsSignedInteger32(Division<TNumerator, TDenominator> division)
    {
        throw new NotImplementedException();
    }

    private static Task<object?> EvaluateAsUnsignedInteger64(Division<TNumerator, TDenominator> division)
    {
        throw new NotImplementedException();
    }

    private static Task<object?> EvaluateAsSignedInteger64(Division<TNumerator, TDenominator> division)
    {
        throw new NotImplementedException();
    }

    private static async Task<object?> EvaluateAsFraction(Division<TNumerator, TDenominator> division)
    {
        var numeratorType = typeof(TNumerator);
        var denominatorType = typeof(TDenominator);
        var fractionType = typeof(Fraction<,>).MakeGenericType(numeratorType, denominatorType);
        return await Task.FromResult(Activator.CreateInstance(fractionType, division.Numerator, division.Denominator));
    }
}
