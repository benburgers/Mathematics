/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Sequence;

namespace BenBurgers.Mathematics.Numbers.Tests.Sequence;

public partial class NumberSequenceNodeTests
{
    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Clone))]
    public void CloneTest()
    {
        // Arrange
        var originalSequence = new nuint[] { 2, 4, 1, 5 };
        var original = (NumberSequence)originalSequence;

        // Act
        var clone = original.Clone();
        var cloneSequence = (nuint[])clone;

        // Assert
        Assert.Equal(originalSequence, cloneSequence);
    }
}