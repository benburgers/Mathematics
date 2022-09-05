/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Resources;

namespace BenBurgers.Mathematics.Logic;

/// <summary>
/// An exception that is thrown if an operation is attempted on an invalid formula.
/// </summary>
public sealed class LogicFormulaInvalidException
    : LogicFormulaException
{
    internal LogicFormulaInvalidException(IEnumerable<int> symbolIndices, string reason)
        : base(ExceptionMessages.FormulaInvalid)
    {
        this.SymbolIndices = symbolIndices.ToArray();
        this.Reason = reason;
    }

    /// <summary>
    /// Gets the indices of the symbols that make the formula invalid.
    /// </summary>
    public IReadOnlyList<int> SymbolIndices { get; }

    /// <summary>
    /// Gets the textual reason why the formula is invalid.
    /// </summary>
    public string Reason { get; }
}