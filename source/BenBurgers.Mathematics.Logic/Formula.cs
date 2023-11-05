/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using System.Collections;
using System.Diagnostics;
using System.Text;

namespace BenBurgers.Mathematics.Logic;

/// <summary>
/// A logical formula.
/// </summary>
[DebuggerDisplay("{DebuggerDisplay,nq}")]
public abstract class Formula
    : IEnumerable<Formula>
{
    private readonly List<Formula> children;

    /// <summary>
    /// Initializes a new instance of <see cref="Formula" />
    /// </summary>
    protected internal Formula()
    {
        this.children = new List<Formula>();
    }

    /// <summary>
    /// Initializes a new instance of <see cref="Formula" />.
    /// </summary>
    /// <param name="children">The formula's children.</param>
    protected internal Formula(IEnumerable<Formula> children)
    {
        this.children = children.ToList();
    }

    private string DebuggerDisplay => this.ToString();

    /// <inheritdoc />
    public IEnumerator<Formula> GetEnumerator()
    {
        return this.children.GetEnumerator();
    }

    /// <summary>
    /// Returns a string representation of the <see cref="Formula" />.
    /// </summary>
    /// <returns>
    /// The string representation of the <see cref="Formula" />.
    /// </returns>
    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        foreach (var formula in this.children)
        {
            stringBuilder.Append(formula.ToString());
        }
        return stringBuilder.ToString();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}