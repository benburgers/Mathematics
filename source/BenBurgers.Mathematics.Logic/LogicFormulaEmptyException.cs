/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Resources;

namespace BenBurgers.Mathematics.Logic;

/// <summary>
/// An exception that is thrown if a formula is empty.
/// </summary>
public sealed class LogicFormulaEmptyException
    : LogicFormulaException
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicFormulaEmptyException" />
    /// </summary>
    public LogicFormulaEmptyException()
        : base(ExceptionMessages.FormulaEmpty)
    {
    }
}