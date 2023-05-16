/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Sequence;

namespace BenBurgers.Mathematics.Numbers.Tests.Sequence;

public partial class NumberSequenceNodeTests
{
    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Cast))]
    public void CastTest()
    {
        // Arrange
        byte b = 20;
        ushort s = 20;
        uint i = 20;
        ulong l = 20;

        // Act
        NumberSequenceNode bbn = b;
        NumberSequenceNode sbn = s;
        NumberSequenceNode ibn = i;
        NumberSequenceNode lbn = l;

        // Assert
        Assert.Equal(b, (byte)bbn);
        Assert.Equal(s, (ushort)sbn);
        Assert.Equal(i, (uint)ibn);
        Assert.Equal(l, (ulong)lbn);
    }
}