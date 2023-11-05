﻿/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Exceptions;

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