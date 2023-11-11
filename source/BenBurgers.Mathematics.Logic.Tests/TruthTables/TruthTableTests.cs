/*
 * This file is part of Ben Burgers Mathematics.
 * 
 * Ben Burgers Mathematics is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License 
 * as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
 * 
 * Ben Burgers Mathematics is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
 * without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 * See the GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License along with Foobar. If not, see <https://www.gnu.org/licenses/>.
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
