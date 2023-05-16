/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Resources;
using System.Runtime.CompilerServices;

namespace BenBurgers.Mathematics.Numbers;

/// <summary>
/// An <see cref="NumberTypeNotSupportedException" /> is thrown if an arithmetic operation is attempted with a number of which the type is not supported.
/// </summary>
public class NumberTypeNotSupportedException
    : NumbersException
{
    /// <summary>
    /// Initializes a new instance of <see cref="NumberTypeNotSupportedException" />.
    /// </summary>
    /// <param name="type">
    /// The type of the number that is not supported.
    /// </param>
    /// <param name="callerName">
    /// The name of the method that caused the exception.
    /// </param>
    public NumberTypeNotSupportedException(Type type, [CallerMemberName] string callerName = "")
        : base(ExceptionMessages.NumberTypeNotSupported)
    {
        this.OperationName = callerName;
        this.Type = type;
    }

    /// <summary>
    /// Gets the name of the operation.
    /// </summary>
    public string OperationName { get; }

    /// <summary>
    /// Gets the type that is not supported.
    /// </summary>
    public Type Type { get; }
}