/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Sets;

namespace BenBurgers.Mathematics.Logic.Symbols;

public abstract partial class Symbol
{
    /// <summary>
    /// Gets a <see cref="SymbolConjunction" />.
    /// </summary>
    /// <returns>
    /// The <see cref="SymbolConjunction" />.
    /// </returns>
    public static SymbolConjunction Conjunction() => SymbolConjunction.Instance;

    /// <summary>
    /// Gets a <see cref="SymbolConjunctionNegation" />.
    /// </summary>
    /// <returns>
    /// The <see cref="SymbolConjunctionNegation" />.
    /// </returns>
    public static SymbolConjunctionNegation ConjunctionNegation() => SymbolConjunctionNegation.Instance;

    /// <summary>
    /// Gets a <see cref="SymbolContradiction" />.
    /// </summary>
    /// <returns>
    /// The <see cref="SymbolContradiction" />.
    /// </returns>
    public static SymbolContradiction Contradiction() => SymbolContradiction.Instance;

    /// <summary>
    /// Gets a <see cref="SymbolDefinition" />.
    /// </summary>
    /// <returns>
    /// The <see cref="SymbolDefinition" />.
    /// </returns>
    public static SymbolDefinition Definition() => SymbolDefinition.Instance;

    /// <summary>
    /// Gets a <see cref="SymbolDisjunction" />.
    /// </summary>
    /// <returns>
    /// The <see cref="SymbolDisjunction" />.
    /// </returns>
    public static SymbolDisjunction Disjunction() => SymbolDisjunction.Instance;

    /// <summary>
    /// Gets a <see cref="SymbolDisjunctionExclusive" />.
    /// </summary>
    /// <returns>
    /// The <see cref="SymbolDisjunctionExclusive" />.
    /// </returns>
    public static SymbolDisjunctionExclusive DisjunctionExclusive() => SymbolDisjunctionExclusive.Instance;

    /// <summary>
    /// Gets a <see cref="SymbolDisjunctionNegation" />.
    /// </summary>
    /// <returns>
    /// The <see cref="SymbolDisjunctionNegation" />.
    /// </returns>
    public static SymbolDisjunctionNegation DisjunctionNegation() => SymbolDisjunctionNegation.Instance;

    /// <summary>
    /// Gets a <see cref="SymbolEquivalence" />.
    /// </summary>
    /// <returns>
    /// The <see cref="SymbolEquivalence" />.
    /// </returns>
    public static SymbolEquivalence Equivalence() => SymbolEquivalence.Instance;

    /// <summary>
    /// Creates a <see cref="SymbolFormulaIdentifier" />.
    /// </summary>
    /// <param name="identifier">
    /// The identifier of the formula.
    /// </param>
    /// <returns>
    /// The <see cref="SymbolFormulaIdentifier" />.
    /// </returns>
    /// <exception cref="AggregateException">
    /// An <see cref="AggregateException" /> is thrown if one or more letters in <paramref name="identifier" /> are invalid.
    /// </exception>
    public static SymbolFormulaIdentifier Formula(string identifier) => SymbolFormulaIdentifier.From(identifier);

    /// <summary>
    /// Creates a <see cref="SymbolFormulaSetIdentifier" />.
    /// </summary>
    /// <param name="identifier">
    /// The identifier of the formula set.
    /// </param>
    /// <returns>
    /// The <see cref="SymbolFormulaSetIdentifier" />.
    /// </returns>
    /// <exception cref="AggregateException">
    /// An <see cref="AggregateException" /> is thrown if one or more letters in <paramref name="identifier" /> are invalid.
    /// </exception>
    public static SymbolFormulaSetIdentifier FormulaSet(string identifier) => SymbolFormulaSetIdentifier.From(identifier);

    /// <summary>
    /// Gets a <see cref="SymbolImplication" />.
    /// </summary>
    /// <returns>
    /// The <see cref="SymbolImplication" />.
    /// </returns>
    public static SymbolImplication Implication() => SymbolImplication.Instance;

    /// <summary>
    /// Gets a <see cref="SymbolNegation" />.
    /// </summary>
    /// <returns>
    /// The <see cref="SymbolNegation" />.
    /// </returns>
    public static SymbolNegation Negation() => SymbolNegation.Instance;

    /// <summary>
    /// Gets a <see cref="SymbolParenthesisClosing" />.
    /// </summary>
    /// <returns>
    /// The <see cref="SymbolParenthesisClosing" />.
    /// </returns>
    public static SymbolParenthesisClosing ParenthesisClose() => SymbolParenthesisClosing.Instance;

    /// <summary>
    /// Gets a <see cref="SymbolParenthesisOpening" />.
    /// </summary>
    /// <returns>
    /// The <see cref="SymbolParenthesisOpening" />.
    /// </returns>
    public static SymbolParenthesisOpening ParenthesisOpen() => SymbolParenthesisOpening.Instance;

    /// <summary>
    /// Creates a <see cref="SymbolPropositionIdentifier" />.
    /// </summary>
    /// <param name="identifier">
    /// The identifier.
    /// </param>
    /// <returns>
    /// A <see cref="SymbolPropositionIdentifier" />.
    /// </returns>
    /// <exception cref="AggregateException">
    /// An <see cref="AggregateException" /> is thrown if one or more letters in <paramref name="identifier" /> are invalid for a proposition identifier.
    /// </exception>
    public static SymbolPropositionIdentifier PropositionIdentifier(string identifier) => SymbolPropositionIdentifier.From(identifier);

    /// <summary>
    /// Creates a <see cref="SymbolQuantification" /> based on the desired quantifier type.
    /// </summary>
    /// <param name="type">
    /// The quantifier type.
    /// </param>
    /// <returns>
    /// The <see cref="SymbolQuantification" />.
    /// </returns>
    /// <exception cref="LogicSymbolQuantifierNotSupportedException">
    /// A <see cref="LogicSymbolQuantifierNotSupportedException" /> is thrown if <paramref name="type" /> is not supported.
    /// </exception>
    public static SymbolQuantification Quantification(QuantifierType type) => SymbolQuantification.Create(type);

    /// <summary>
    /// Gets a <see cref="SymbolSemanticConsequence" />.
    /// </summary>
    /// <returns>
    /// The <see cref="SymbolSemanticConsequence" />.
    /// </returns>
    public static SymbolSemanticConsequence SemanticConsequence() => SymbolSemanticConsequence.Instance;

    /// <summary>
    /// Gets a <see cref="SymbolSyntacticConsequence" />.
    /// </summary>
    /// <returns>
    /// The <see cref="SymbolSyntacticConsequence" />.
    /// </returns>
    public static SymbolSyntacticConsequence SyntacticConsequence() => SymbolSyntacticConsequence.Instance;

    /// <summary>
    /// Gets a <see cref="SymbolTautology" />.
    /// </summary>
    /// <returns>
    /// The <see cref="SymbolTautology" />.
    /// </returns>
    public static SymbolTautology Tautology() => SymbolTautology.Instance;
}