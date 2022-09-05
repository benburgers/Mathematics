/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Sequence;

namespace BenBurgers.Mathematics.Numbers.Tests.Sequence;

public partial class NumberSequenceTests
{
    private static readonly nuint[][] Values =
        new[]
        {
            new nuint[] { 2, 3, 5, 2, 1, 6, 3 },
            new nuint[] { 3, 4, 1, 3, 6, 2, 5 },
            new nuint[] { 1, 2, 3 }
        };

    [Theory]
    [InlineData(0, 0, true)]
    [InlineData(0, 1, false)]
    [InlineData(1, 0, false)]
    [InlineData(1, 2, false)]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTest(int valuesIndexLeft, int valuesIndexRight, bool expected)
    {
        // Arrange
        var valuesLeft = Values[valuesIndexLeft];
        var valuesRight = Values[valuesIndexRight];
        var sequenceLeft = (NumberSequence)valuesLeft;
        var sequenceRight = (NumberSequence)valuesRight;

        // Act
        var actual = sequenceLeft.Equals(sequenceRight);

        // Assert
        Assert.Equal(expected, actual);
    }
}