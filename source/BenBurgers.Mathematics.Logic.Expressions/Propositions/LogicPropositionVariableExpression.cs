/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using System.Linq.Expressions;
using BenBurgers.Mathematics.Logic.Propositions.Variables;

namespace BenBurgers.Mathematics.Logic.Expressions.Propositions;

/// <summary>
/// An expression for a variable.
/// </summary>
public class LogicPropositionVariableExpression
    : LogicExpression
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicPropositionVariableExpression" />.
    /// </summary>
    /// <param name="propositionVariable">
    /// The proposition variable.
    /// </param>
    public LogicPropositionVariableExpression(PropositionVariable propositionVariable)
    {
        PropositionVariable = propositionVariable;
    }

    /// <inheritdoc />
    public override bool CanReduce => false;

    /// <summary>
    /// Gets the identifier of the variable.
    /// </summary>
    public PropositionVariable PropositionVariable { get; }

    /// <inheritdoc />
    public override LogicExpression Clone()
    {
        return new LogicPropositionVariableExpression(this.PropositionVariable);
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return PropositionVariable.Identifier;
    }

    /// <inheritdoc />
    protected override Expression VisitChildren(ExpressionVisitor visitor)
    {
        return this;
    }
}