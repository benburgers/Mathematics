/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Expressions.Visitors;
using System.Linq.Expressions;

namespace BenBurgers.Mathematics.Logic.Expressions.Tests.Visitors;

public class LogicExpressionTranslatingVisitorTests
{
    private record TestUnit(Expression Expression, Type ExpressionType, Action<LogicExpression> Assert);
    private static readonly IReadOnlyList<TestUnit> TestUnits =
        new TestUnit[]
        {
            // UnaryExpression
            new(
                Expression.MakeUnary(ExpressionType.Not, Expression.Variable(typeof(bool), "a"), typeof(bool)),
                typeof(LogicNegationExpression),
                logicExpression =>
                {
                    var negation = (LogicNegationExpression)logicExpression;
                    Assert.Equal("a", ((LogicPropositionVariableExpression)negation.Operand).PropositionVariable.Identifier);
                }),
            // BinaryExpression
            new(
                Expression.MakeBinary(ExpressionType.And, Expression.Variable(typeof(bool), "b"), Expression.Variable(typeof(bool), "c")),
                typeof(LogicConjunctionExpression),
                logicExpression =>
                {
                    var conjunction = (LogicConjunctionExpression)logicExpression;
                    Assert.Equal("b", ((LogicPropositionVariableExpression)conjunction.Left).PropositionVariable.Identifier);
                    Assert.Equal("c", ((LogicPropositionVariableExpression)conjunction.Right).PropositionVariable.Identifier);
                }),
            new(
                Expression.MakeBinary(ExpressionType.Or, Expression.Variable(typeof(bool), "d"), Expression.Variable(typeof(bool), "e")),
                typeof(LogicDisjunctionExpression),
                logicExpression =>
                {
                    var disjunction = (LogicDisjunctionExpression)logicExpression;
                    Assert.Equal("d", ((LogicPropositionVariableExpression)disjunction.Left).PropositionVariable.Identifier);
                    Assert.Equal("e", ((LogicPropositionVariableExpression)disjunction.Right).PropositionVariable.Identifier);
                }),
            // ConstantExpression
            new(
                Expression.Constant(true),
                typeof(LogicValueExpression),
                logicExpression =>
                {
                    var tautology = (LogicValueExpression)logicExpression;
                    Assert.Equal("1", tautology.ToString());
                }),
            new(
                Expression.Constant(false),
                typeof(LogicValueExpression),
                logicExpression =>
                {
                    var contradiction = (LogicValueExpression)logicExpression;
                    Assert.Equal("0", contradiction.ToString());
                })
        };

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void BinaryTest(int unitIndex)
    {
        // Arrange
        var translatingVisitor = new LogicExpressionTranslatingVisitor();
        var (expression, expressionType, assert) = TestUnits[unitIndex];

        // Act
        var logicBinaryExpression = (LogicBinaryExpression)translatingVisitor.Visit(expression);

        // Assert
        Assert.IsType(expressionType, logicBinaryExpression);
        assert(logicBinaryExpression);
    }

    [Theory]
    [InlineData(3)]
    [InlineData(4)]
    public void ConstantTest(int unitIndex)
    {
        // Arrange
        var translatingVisitor = new LogicExpressionTranslatingVisitor();
        var (expression, expressionType, assert) = TestUnits[unitIndex];

        // Act
        var logicConstantExpression = translatingVisitor.Visit(expression);

        // Assert
        Assert.IsType(expressionType, logicConstantExpression);
        assert(logicConstantExpression);
    }

    [Theory]
    [InlineData(0)]
    public void UnaryTest(int unitIndex)
    {
        // Arrange
        var translatingVisitor = new LogicExpressionTranslatingVisitor();
        var (expression, expressionType, assert) = TestUnits[unitIndex];

        // Act
        var logicUnaryExpression = (LogicUnaryExpression)translatingVisitor.Visit(expression);

        // Assert
        Assert.IsType(expressionType, logicUnaryExpression);
        assert(logicUnaryExpression);
    }
}