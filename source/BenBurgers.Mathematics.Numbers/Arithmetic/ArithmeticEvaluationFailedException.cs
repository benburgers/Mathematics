/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic.Resources;

namespace BenBurgers.Mathematics.Numbers.Arithmetic
{
    /// <summary>
    /// An exception that is thrown if an evaluation of an arithmetic operation has failed.
    /// </summary>
    public class ArithmeticEvaluationFailedException
        : ArithmeticException
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ArithmeticEvaluationFailedException" />.
        /// </summary>
        /// <param name="numberType">
        /// The type of the number to which the arithmetic operation is evaluated.
        /// </param>
        public ArithmeticEvaluationFailedException(Type numberType)
            : base(ExceptionMessages.ArithmeticEvaluationFailed, numberType)
        {
        }
    }
}