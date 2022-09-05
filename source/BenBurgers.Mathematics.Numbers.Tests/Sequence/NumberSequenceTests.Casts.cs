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
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Cast))]
    public void CastTest()
    {
        // Arrange
        var values = new nuint[] { 2, 1, 5, 3, 4 };

        // Act
        var sequence = (NumberSequence)values;
        var actual = (nuint[])sequence;

        // Assert
        Assert.Equal(values, actual);
    }
}