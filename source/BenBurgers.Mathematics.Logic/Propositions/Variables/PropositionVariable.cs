/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Symbols;

namespace BenBurgers.Mathematics.Logic.Propositions.Variables;

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
public abstract class PropositionVariable
    : PropositionalFormula
{
    /// <summary>
    /// Initializes a new instance of <see cref="PropositionVariable" />.
    /// </summary>
    /// <param name="identifier">
    /// The identifier of the proposition variable.
    /// </param>
    protected PropositionVariable(string identifier)
        : base()
    {
        this.Identifier = identifier;
    }

    /// <summary>
    /// Gets the identifier of the proposition variable.
    /// </summary>
    public string Identifier { get; }

    /// <summary>
    /// Gets the formulaic symbol that represents the proposition variable.
    /// </summary>
    public SymbolPropositionIdentifier Symbol => Symbols.Symbol.PropositionIdentifier(this.Identifier);

    /// <summary>
    /// Gets the value of the proposition value.
    /// </summary>
    public abstract bool Value { get; }
}
