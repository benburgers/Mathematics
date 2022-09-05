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
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestSequenceEqual()
    {
        // Arrange
        var valuesLeft = new nuint[] { 2, 5, 6, 3 };
        var sequenceLeft = (NumberSequence)valuesLeft;
        var nodeLeft = sequenceLeft.StartNode;
        var valuesRight = new nuint[] { 2, 5, 6, 3 };
        var sequenceRight = (NumberSequence)valuesRight;
        var nodeRight = sequenceRight.StartNode;

        // Act
        var equals = nodeLeft.Equals(nodeRight);

        // Assert
        Assert.True(equals);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestSequenceNotEqualItems()
    {
        // Arrange
        var valuesLeft = new nuint[] { 2, 5, 6, 3 };
        var sequenceLeft = (NumberSequence)valuesLeft;
        var nodeLeft = sequenceLeft.StartNode;
        var valuesRight = new nuint[] { 3, 2, 7, 8 };
        var sequenceRight = (NumberSequence)valuesRight;
        var nodeRight = sequenceRight.StartNode;

        // Act
        var notEquals = !nodeLeft.Equals(nodeRight);

        // Assert
        Assert.True(notEquals);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestSequenceNotEqualLength()
    {
        // Arrange
        var valuesLeft = new nuint[] { 2, 5, 6, 3 };
        var sequenceLeft = (NumberSequence)valuesLeft;
        var nodeLeft = sequenceLeft.StartNode;
        var valuesRight = new nuint[] { 2, 3 };
        var sequenceRight = (NumberSequence)valuesRight;
        var nodeRight = sequenceRight.StartNode;

        // Act
        var notEquals = !nodeLeft.Equals(nodeRight);

        // Assert
        Assert.True(notEquals);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestValueEqual()
    {
        // Arrange
        var valuesLeft = new nuint[] { 2, 5, 6, 3 };
        var sequenceLeft = (NumberSequence)valuesLeft;
        var nodeLeft = sequenceLeft.StartNode;
        var valuesRight = new nuint[] { 2, 3, 1, 6 };
        var sequenceRight = (NumberSequence)valuesRight;
        var nodeRight = sequenceRight.StartNode;

        // Act
        var equals = nodeLeft.Equals(nodeRight, valueOnly: true);

        // Assert
        Assert.True(equals);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestValueNotEqual()
    {
        // Arrange
        var valuesLeft = new nuint[] { 2, 5, 6, 3 };
        var sequenceLeft = (NumberSequence)valuesLeft;
        var nodeLeft = sequenceLeft.StartNode;
        var valuesRight = new nuint[] { 3, 5, 6, 3 };
        var sequenceRight = (NumberSequence)valuesRight;
        var nodeRight = sequenceRight.StartNode;

        // Act
        var notEquals = !nodeLeft.Equals(nodeRight, valueOnly: true);

        // Assert
        Assert.True(notEquals);
    }
}
