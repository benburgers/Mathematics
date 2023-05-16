/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Propositions.Variables;
using BenBurgers.Mathematics.Logic.TruthTables;

namespace BenBurgers.Mathematics.Logic.Tests.TruthTables;

public sealed class TruthTableTests
{
    public static readonly IEnumerable<object?[]> ToStringParameters =
        new[]
        {
            new object?[]
            {
                new TruthTable(new PropositionVariable[] { new PropositionVariableStatic("a", true) }),
                "a"
            },
            new object?[]
            {
                new TruthTable(new PropositionVariable[] { new PropositionVariableStatic("b", true) }),
                "b"
            }
        };

    [Theory(DisplayName = $"{nameof(TruthTable)} :: {nameof(TruthTable.ToString)}")]
    [MemberData(nameof(ToStringParameters))]
    public void ToStringTests(TruthTable truthTable, string expected)
    {
        var actual = truthTable.ToString();
        Assert.Equal(expected, actual);
    }
}
