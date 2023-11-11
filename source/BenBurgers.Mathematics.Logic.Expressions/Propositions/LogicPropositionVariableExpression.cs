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

using System.Linq.Expressions;
using BenBurgers.Mathematics.Logic.Propositions.Variables;

namespace BenBurgers.Mathematics.Logic.Expressions.Propositions;

/// <summary>
/// An expression for a variable.
/// </summary>
public class LogicPropositionVariableExpression
    : LogicExpression
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicPropositionVariableExpression" />.
    /// </summary>
    /// <param name="propositionVariable">
    /// The proposition variable.
    /// </param>
    public LogicPropositionVariableExpression(PropositionVariable propositionVariable)
    {
        PropositionVariable = propositionVariable;
    }

    /// <inheritdoc />
    public override bool CanReduce => false;

    /// <summary>
    /// Gets the identifier of the variable.
    /// </summary>
    public PropositionVariable PropositionVariable { get; }

    /// <inheritdoc />
    public override LogicExpression Clone()
    {
        return new LogicPropositionVariableExpression(this.PropositionVariable);
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return PropositionVariable.Identifier;
    }

    /// <inheritdoc />
    protected override Expression VisitChildren(ExpressionVisitor visitor)
    {
        return this;
    }
}