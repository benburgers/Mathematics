/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using System.Text;

namespace BenBurgers.Mathematics.Logic.TruthTables;

/// <summary>
/// Represents a logic truth table.
/// </summary>
public class TruthTable
{
    private readonly IList<Formula> formulae;

    /// <summary>
    /// Initializes a new instance of <see cref="TruthTable" />.
    /// </summary>
    /// <param name="formulae">
    /// The logic formulae for the truth table.
    /// </param>
    public TruthTable(IEnumerable<Formula> formulae)
    {
        this.formulae = formulae.ToList();
    }

    /// <summary>
    /// Gets the components for the columns of the table.
    /// </summary>
    public IEnumerable<Formula> Columns => this.formulae;

    /// <summary>
    /// Returns a string representation of the truth table.
    /// </summary>
    /// <returns>
    /// A string representation of the truth table.
    /// </returns>
    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        foreach (var column in this.Columns)
        {
            stringBuilder.Append(column.ToString());
        }
        return stringBuilder.ToString();
    }
}