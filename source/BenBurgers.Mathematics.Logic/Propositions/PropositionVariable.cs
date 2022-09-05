/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Propositions;

/// <summary>
/// Represents a proposition variable.
/// </summary>
/// <example>
///     <list type="bullet">
///         <item>a</item>
///         <item>p</item>
///     </list>
/// </example>
/// <remarks>
/// A variable in a propositional formula.
/// </remarks>
public class PropositionVariable
{
    /// <summary>
    /// Initializes a new instance of <see cref="PropositionVariable" />.
    /// </summary>
    /// <param name="identifier">
    /// The identifier of the proposition variable.
    /// </param>
    /// <param name="valueGetter">
    /// A delegate that gets the current value of the proposition variable.
    /// </param>
    public PropositionVariable(string identifier, Func<bool> valueGetter)
    {
        this.Identifier = identifier;
        this.ValueGetter = valueGetter;
    }

    /// <summary>
    /// Gets the identifier of the proposition variable.
    /// </summary>
    public string Identifier { get; }

    /// <summary>
    /// Gets the delegate that gets the current value of the proposition variable.
    /// </summary>
    public Func<bool> ValueGetter { get; }
}
