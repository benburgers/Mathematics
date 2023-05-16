/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Expressions.Tests;

public class LogicTautologyExpressionTests
{
    [Fact]
    public void ToStringTest()
    {
        // Arrange
        var tautologyExpression = LogicTautologyExpression.Instance;

        // Act
        var result = tautologyExpression.ToString();

        // Assert
        Assert.Equal("⊤", result);
    }
}