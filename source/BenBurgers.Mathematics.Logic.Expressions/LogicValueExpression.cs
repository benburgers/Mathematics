/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Expressions;

/// <summary>
/// A logical value.
/// </summary>
/// <remarks>
/// True, false or undetermined.
/// </remarks>
/// <example>
/// <list type="bullet">
/// <item>1</item>
/// <item>0</item>
/// <item>?</item>
/// </list>
/// </example>
public class LogicValueExpression
    : LogicExpression
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicValueExpression" />.
    /// </summary>
    /// <param name="value">
    /// The value.
    /// </param>
    public LogicValueExpression(bool? value)
    {
        this.Value = value;
    }

    /// <summary>
    /// Gets the value.
    /// </summary>
    public bool? Value { get; }

    /// <inheritdoc />
    public override LogicValueExpression Clone()
    {
        return new LogicValueExpression(this.Value);
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return this.Value switch
        {
            null => "?",
            true => "1",
            false => "0"
        };
    }
}