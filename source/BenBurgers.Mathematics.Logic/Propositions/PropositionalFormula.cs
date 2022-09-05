/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Symbols;

namespace BenBurgers.Mathematics.Logic.Propositions;

/// <summary>
/// A propositional formula.
/// </summary>
public sealed class PropositionalFormula
    : Formula
{
    private enum State
    {
        /// <summary>
        /// Ready to accept a new (sub)formula.
        /// </summary>
        Empty,

        /// <summary>
        /// An opening parenthesis was encountered.
        /// </summary>
        EnclosureStart,

        /// <summary>
        /// A closing parenthesis was encountered.
        /// </summary>
        EnclosureEnd,

        /// <summary>
        /// Receiving an identifier.
        /// </summary>
        Identifier,

        /// <summary>
        /// Receiving a binary expression.
        /// </summary>
        Binary
    }

    private int level;
    private State state;

    /// <summary>
    /// Initializes a new instance of <see cref="PropositionalFormula" />.
    /// </summary>
    /// <param name="symbols">
    /// The symbols that comprise the formula.
    /// </param>
    /// <exception cref="LogicFormulaEmptyException">
    /// A <see cref="LogicFormulaEmptyException" /> is thrown if the formula is empty.
    /// </exception>
    /// <exception cref="LogicFormulaInvalidSymbolInCurrentStateException">
    /// A <see cref="LogicFormulaInvalidSymbolInCurrentStateException" /> is thrown if the syntax of the <paramref name="symbols" /> is invalid for a formula.
    /// </exception>
    public PropositionalFormula(IEnumerable<Symbol> symbols)
        : base()
    {
        this.level = 0;
        foreach (var symbol in symbols)
            this.Add(symbol);
        if (this.state == State.Empty)
            throw new LogicFormulaEmptyException();
        if (this.level != 0)
            throw new LogicFormulaEmptyException();
    }

    /// <inheritdoc />
    protected override bool AddGuard(Symbol symbol)
    {
        bool IsBinary()
        {
            return symbol is
                SymbolDisjunction
                or SymbolDisjunctionExclusive
                or SymbolDisjunctionNegation
                or SymbolConjunction
                or SymbolConjunctionNegation
                or SymbolImplication
                or SymbolEquivalence;
        }

        switch (this.state)
        {
            case State.Empty when symbol is SymbolParenthesisOpening:
                this.state = State.EnclosureStart;
                return true;
            case State.Empty when symbol is SymbolPropositionIdentifier:
                this.state = State.Identifier;
                return true;
            case State.EnclosureStart when symbol is SymbolPropositionIdentifier:
                this.state = State.Identifier;
                level++;
                return true;
            case State.EnclosureEnd when IsBinary():
            case State.Identifier when IsBinary():
                this.state = State.Binary;
                return true;
            case State.Identifier when symbol is SymbolParenthesisClosing && this.level == 0:
                return false;
            case State.Identifier when symbol is SymbolParenthesisClosing:
                this.state = State.EnclosureEnd;
                level--;
                return true;
            case State.Binary when symbol is SymbolPropositionIdentifier:
                this.state = State.Identifier;
                return true;
            default:
                return false;
        }
    }
}