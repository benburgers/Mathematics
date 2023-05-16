/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Resources;
using BenBurgers.Mathematics.Logic.Symbols;

namespace BenBurgers.Mathematics.Logic;

/// <summary>
/// An exception that is thrown if a symbol is being added to a formula in a state that does not accept it.
/// </summary>
public class LogicFormulaInvalidSymbolInCurrentStateException
    : LogicFormulaException
{
    internal LogicFormulaInvalidSymbolInCurrentStateException(Symbol symbol)
        : base(ExceptionMessages.FormulaInvalidSymbolInCurrentState)
    {
        this.Symbol = symbol;
    }

    /// <summary>
    /// Gets the symbol that was not accepted.
    /// </summary>
    public Symbol Symbol { get; }
}