/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Symbols;

public abstract partial class Symbol
{
    /// <summary>
    /// The logical conjunction.
    /// </summary>
    internal const char ConjunctionChar = '∧';

    /// <summary>
    /// The contradiction symbol.
    /// </summary>
    internal const char ContradictionChar = '⊥';

    /// <summary>
    /// The definition symbol.
    /// </summary>
    internal const char DefinitionChar = '≔';

    /// <summary>
    /// The logical inclusive disjunction.
    /// </summary>
    internal const char DisjunctionChar = '∨';

    /// <summary>
    /// The logical exclusive disjunction.
    /// </summary>
    internal const char DisjunctionExclusiveChar = '⊻';

    /// <summary>
    /// The material equivalence symbol.
    /// </summary>
    internal const char EquivalenceChar = '↔';

    /// <summary>
    /// Single-letter formulae.
    /// </summary>
    internal const string FormulaLetters = "αβγδεζηθικλμνξοπρστυφχψω";

    /// <summary>
    /// Single-letter formula sets.
    /// </summary>
    internal const string FormulaSetLetters = "ΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩ";

    /// <summary>
    /// The material implication symbol.
    /// </summary>
    internal const char ImplicationChar = '→';

    /// <summary>
    /// The negation symbol.
    /// </summary>
    internal const char NegationChar = '¬';

    /// <summary>
    /// A closing parenthesis symbol.
    /// </summary>
    internal const char ParenthesisClosingChar = ')';

    /// <summary>
    /// An opening parenthesis symbol.
    /// </summary>
    internal const char ParenthesisOpenChar = '(';

    /// <summary>
    /// The Peirce Arrow.
    /// </summary>
    internal const char PeirceArrowChar = '↓';

    /// <summary>
    /// Single-letter predicates.
    /// </summary>
    internal const string PredicateLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    /// <summary>
    /// Single-letter propositions.
    /// </summary>
    internal const string PropositionLetters = "abcdefghijklmnopqrstuvwxyz";

    /// <summary>
    /// The existential quantification symbol.
    /// </summary>
    internal const char QuantificationExistentialChar = '∃';

    /// <summary>
    /// The uniqueness quantification symbol.
    /// </summary>
    internal const string QuantificationUniquenessString = "∃!";

    /// <summary>
    /// The universal quantification symbol.
    /// </summary>
    internal const char QuantificationUniversalChar = '∀';

    /// <summary>
    /// The Sheffer Stroke.
    /// </summary>
    internal const char ShefferStrokeChar = '↑';

    /// <summary>
    /// The tautology symbol.
    /// </summary>
    internal const char TautologyChar = '⊤';

    /// <summary>
    /// The turnstile symbol.
    /// </summary>
    internal const char Turnstile = '⊢';

    /// <summary>
    /// The double turnstile symbol.
    /// </summary>
    internal const char TurnstileDouble = '⊨';
}