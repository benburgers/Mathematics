/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Expressions.Abstractions;

/// <summary>
/// A logical binary expression.
/// </summary>
public interface ILogicBinaryExpression
{
    /// <summary>
    /// Gets the left hand side of the expression.
    /// </summary>
    LogicExpression Left { get; }

    /// <summary>
    /// Gets the right hand side of the expression.
    /// </summary>
    LogicExpression Right { get; }
    
    /// <summary>
    /// Gets any other operands in the expression, if it can be chained.
    /// </summary>
    IReadOnlyList<LogicExpression> Others { get; }
}