/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Expressions.Propositions;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace BenBurgers.Mathematics.Logic.Expressions.Visitors;

/// <summary>
/// Visits an expression tree and normalizes them to logic expressions.
/// </summary>
public sealed class LogicExpressionTranslatingVisitor
    : ExpressionVisitor
{
    private readonly Dictionary<string, Func<bool>> variables;

    /// <summary>
    /// Initializes a new instance of <see cref="LogicExpressionTranslatingVisitor" />.
    /// </summary>
    public LogicExpressionTranslatingVisitor()
    {
        this.variables = new Dictionary<string, Func<bool>>();
    }

    /// <inheritdoc />
    [return: NotNullIfNotNull("node")]
    public override LogicExpression? Visit(Expression? node)
    {
        return (LogicExpression?)base.Visit(node);
    }

    /// <inheritdoc />
    /// <exception cref="NotSupportedException">
    /// A <see cref="NotSupportedException" /> is thrown if the expression type is not supported.
    /// </exception>
    protected override LogicBinaryExpression VisitBinary(BinaryExpression node)
    {
        return node.NodeType switch
        {
            ExpressionType.And => new LogicConjunctionExpression(this.Visit(node.Left), this.Visit(node.Right)),
            ExpressionType.AndAlso => new LogicConjunctionExpression(this.Visit(node.Left), this.Visit(node.Right)),
            ExpressionType.Or => new LogicDisjunctionExpression(this.Visit(node.Left), this.Visit(node.Right)),
            ExpressionType.OrElse => new LogicDisjunctionExpression(this.Visit(node.Left), this.Visit(node.Right)),
            _ => throw new NotSupportedException()
        };
    }

    /// <inheritdoc />
    /// <exception cref="NotSupportedException">
    /// A <see cref="NotSupportedException" /> is thrown if the expression type is not supported.
    /// </exception>
    protected override LogicExpression VisitConditional(ConditionalExpression node)
    {
        var test = this.Visit(node.Test);
        var ifTrue = this.Visit(node.IfTrue);
        var ifFalse = this.Visit(node.IfFalse);

        return new LogicDisjunctionExpression(
            new LogicImplicationExpression(test, ifTrue),
            new LogicImplicationExpression(new LogicNegationExpression(test), ifFalse)
        );
    }

    /// <inheritdoc />
    /// <exception cref="NotSupportedException">
    /// A <see cref="NotSupportedException" /> is thrown if the expression type is not supported.
    /// </exception>
    protected override LogicExpression VisitConstant(ConstantExpression node)
    {
        return node.Value switch
        {
            null => new LogicValueExpression(null),
            true => new LogicValueExpression(true),
            false => new LogicValueExpression(false),
            _ => throw new NotSupportedException()
        };
    }

    /// <inheritdoc />
    protected override LogicPropositionVariableExpression VisitParameter(ParameterExpression node)
    {
        var variableType = node.Type;
        if (!this.variables.TryGetValue(node.Name!, out var propositionValueGetter) || propositionValueGetter is null)
            this.variables[node.Name!] = propositionValueGetter = new Func<bool>(() => true);
        return new LogicPropositionVariableExpression(new PropositionVariable(node.Name!, propositionValueGetter!));
    }

    /// <inheritdoc />
    protected override LogicExpression VisitUnary(UnaryExpression node)
    {
        return node.NodeType switch
        {
            ExpressionType.Not => new LogicNegationExpression(this.Visit(node.Operand)),
            _ => throw new NotSupportedException()
        };
    }
}