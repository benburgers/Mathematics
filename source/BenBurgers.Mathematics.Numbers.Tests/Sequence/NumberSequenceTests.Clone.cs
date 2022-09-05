/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Sequence;

namespace BenBurgers.Mathematics.Numbers.Tests.Sequence;

public partial class NumberSequenceTests
{
    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Clone))]
    public void CloneTest()
    {
        // Arrange
        var sequenceValues = new nuint[] { 2, 3, 1, 2 };
        var sequence = (NumberSequence)sequenceValues;

        // Act
        var copy = sequence.Clone();

        // Assert
        var copyValues = (nuint[])copy;
        Assert.Equal(sequenceValues, copyValues);
    }
}