/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Symbols;
using System.Collections;
using System.Text;

namespace BenBurgers.Mathematics.Logic;

/// <summary>
/// A logical formula.
/// </summary>
public abstract class Formula
    : IEnumerable<Symbol>
{
    private readonly List<Symbol> symbols;

    /// <summary>
    /// Initializes a new instance of <see cref="Formula" />
    /// </summary>
    protected internal Formula()
    {
        this.symbols = new List<Symbol>();
    }

    /// <summary>
    /// Adds a symbol to the formula.
    /// </summary>
    /// <param name="symbol">
    /// The symbol to add to the formula.
    /// </param>
    /// <exception cref="LogicFormulaInvalidSymbolInCurrentStateException">
    /// A <see cref="LogicFormulaInvalidSymbolInCurrentStateException" /> is thrown 
    /// if the <paramref name="symbol" /> cannot be added in the current state of the formula.
    /// </exception>
    protected virtual void Add(Symbol symbol)
    {
        if (!this.AddGuard(symbol))
            throw new LogicFormulaInvalidSymbolInCurrentStateException(symbol);
        this.symbols.Add(symbol);
    }

    /// <summary>
    /// Performs checks on the symbol before adding it to the formula.
    /// </summary>
    /// <param name="symbol">
    /// The symbol to add.
    /// </param>
    /// <returns>
    /// A <see langword="bool" /> that indicates whether the <paramref name="symbol" /> may be added to the formula.
    /// </returns>
    protected abstract bool AddGuard(Symbol symbol);

    /// <inheritdoc />
    public IEnumerator<Symbol> GetEnumerator()
    {
        return this.symbols.GetEnumerator();
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
        foreach (var symbol in this.symbols)
        {
            stringBuilder.Append(symbol.ToString());
        }
        return stringBuilder.ToString();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}