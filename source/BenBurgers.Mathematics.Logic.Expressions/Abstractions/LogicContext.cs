/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Expressions.Abstractions;

/// <summary>
/// The logic context of an expression tree.
/// </summary>
public sealed class LogicContext
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicContext" />.
    /// </summary>
    public LogicContext()
    {
        this.PropositionVariables = new SortedSet<PropositionVariable>();
    }

    /// <summary>
    /// Gets the proposition variables in the context.
    /// </summary>
    public SortedSet<PropositionVariable> PropositionVariables { get; }
}