/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Predicates;

/// <summary>
/// A predicate function.
/// </summary>
/// <typeparam name="TParameter">
/// The type of the parameter for the predicate function.
/// </typeparam>
/// <remarks>
/// If the predicate function receives more than one value in its parameters, 
/// <typeparamref name="TParameter" /> should wrap these values.
/// </remarks>
public class PredicateFunction<TParameter>
{
    /// <summary>
    /// Initializes a new instance of <see cref="PredicateFunction{TParameter}" />.
    /// </summary>
    /// <param name="identifier">
    /// The identifier of the predicate function.
    /// </param>
    /// <param name="predicate">
    /// The predicate function.
    /// </param>
    public PredicateFunction(string identifier, Func<TParameter, bool> predicate)
    {
        this.Identifier = identifier;
        this.Predicate = predicate;
    }

    /// <summary>
    /// Gets the identifier of the predicate function.
    /// </summary>
    public string Identifier { get; }

    /// <summary>
    /// Gets the predicate function.
    /// </summary>
    public Func<TParameter, bool> Predicate { get; }
}
