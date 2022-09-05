/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Expressions.Tests;

public class LogicContradictionExpressionTests
{
    [Fact]
    public void ToStringTest()
    {
        // Arrange
        var contradictionExpression = LogicContradictionExpression.Instance;

        // Act
        var result = contradictionExpression.ToString();

        // Assert
        Assert.Equal("⊥", result);
    }
}