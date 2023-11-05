/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Exceptions;

/// <summary>
/// An exception that is thrown if an operation is attempted on an invalid formula.
/// </summary>
public sealed class LogicFormulaInvalidException
    : LogicFormulaException
{
    internal LogicFormulaInvalidException(IEnumerable<int> symbolIndices, string reason)
        : base(ExceptionMessages.FormulaInvalid)
    {
        SymbolIndices = symbolIndices.ToArray();
        Reason = reason;
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