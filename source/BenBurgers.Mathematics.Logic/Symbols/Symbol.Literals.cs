/*
 * This file is part of Ben Burgers Mathematics.
 * 
 * Ben Burgers Mathematics is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License 
 * as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
 * 
 * Ben Burgers Mathematics is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
 * without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 * See the GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License along with Foobar. If not, see <https://www.gnu.org/licenses/>.
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