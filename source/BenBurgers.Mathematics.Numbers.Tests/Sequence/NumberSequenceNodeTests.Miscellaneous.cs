/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers.Tests.Sequence;

public partial class NumberSequenceNodeTests
{
    [Fact]
    public void BaseTenTest()
    {
        // Arrange
        nuint two = 2;
        nuint twenty = 2;

        // Act
        var twentyShift = (twenty << 3) + (twenty << 1);
        var twoHundredShift = (twentyShift << 3) + (twentyShift << 1);
        var twoThousandShift = (twoHundredShift << 3) + (twoHundredShift << 1);
        var twoThousandTwoHundredTwentyTwo = two + twentyShift + twoHundredShift + twoThousandShift;

        // Assert
        Assert.Equal((nuint)2222, twoThousandTwoHundredTwentyTwo);
    }

    [Theory]
    [InlineData(
        (ushort)0b0000_0000_0000_0011,
        (ushort)0b0000_0000_0000_0001,
        (ushort)0b0000_0000_0000_0000)] // 3 % 1 = 0
    [InlineData(
        (ushort)0b0000_0000_0000_1111,
        (ushort)0b0000_0000_0000_0011,
        (ushort)0b0000_0000_0000_0000)] // 15 % 3 = 0
    [InlineData(
        (ushort)0b0000_0000_1111_1111,
        (ushort)0b0000_0000_0001_1100,
        (ushort)0b0000_0000_0000_0011)] // 255 % 28 = 3
    public void ModulusTest(ushort dividend, ushort divisor, ushort expected)
    {
        // Arrange
        var size = sizeof(ushort);
        var bitLength = (ushort)(size * 8);

        // Act
        var actual = dividend;
        for (var bitShift = bitLength; bitShift >= 0; bitShift--)
        {
            var divShifted = (ushort)(divisor << bitShift);
            actual = (ushort)(actual - (actual & divShifted));
            if (bitShift == 0)
                break;
        }

        // Assert
        Assert.Equal(expected, actual);
    }
}
