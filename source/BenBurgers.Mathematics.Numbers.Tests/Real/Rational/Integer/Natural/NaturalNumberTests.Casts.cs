/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;
using BenBurgers.Mathematics.Numbers.Sequence;

namespace BenBurgers.Mathematics.Numbers.Tests.Real.Rational.Integer.Natural;

public partial class NaturalNumberTests
{
    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Cast))]
    public void CastTestHappy()
    {
        // Arrange
        byte b = 1;
        sbyte sb = 1;
        short s = 1;
        ushort us = 1;
        int i = 1;
        uint ui = 1;
        long l = 1L;
        ulong ul = 1UL;
        float f = 1.0F;
        double d = 1.0D;
        decimal m = 1.0M;

        var intNodeSequence = (NumberSequence)new nuint[] { 2 };
        IntegerNumber intNum = new(intNodeSequence, false);

        // Act
        var bnn = (NaturalNumber)b;
        var sbnn = (NaturalNumber)sb;
        var snn = (NaturalNumber)s;
        var usnn = (NaturalNumber)us;
        var inn = (NaturalNumber)i;
        var uinn = (NaturalNumber)ui;
        var lnn = (NaturalNumber)l;
        var ulnn = (NaturalNumber)ul;
        var fnn = (NaturalNumber)f;
        var dnn = (NaturalNumber)d;
        var mnn = (NaturalNumber)m;
        var innn = (NaturalNumber)intNum;

        // Assert
        Assert.Equal(b, (byte)bnn);
        Assert.Equal(sb, (sbyte)sbnn);
        Assert.Equal(s, (short)snn);
        Assert.Equal(us, (ushort)usnn);
        Assert.Equal(i, (int)inn);
        Assert.Equal(ui, (uint)uinn);
        Assert.Equal(l, (long)lnn);
        Assert.Equal(ul, (ulong)ulnn);
        Assert.Equal(f, (float)fnn);
        Assert.Equal(d, (double)dnn);
        Assert.Equal(m, (decimal)mnn);
        Assert.Equal(intNum, (IntegerNumber)innn);
    }
}