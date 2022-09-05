/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers.Arithmetic;

/// <summary>
/// The options for an arithmetic operation.
/// </summary>
/// <param name="AllowOverflow">
/// Indicates whether an overflow after the operation is allowed.
/// </param>
/// <param name="Timeout">
/// The time that the evaluation may take the longest.
/// </param>
public record ArithmeticOptions(
    bool AllowOverflow,
    TimeSpan Timeout)
{
    private static readonly object DefaultOptionsLock = new();
    private static ArithmeticOptions defaultOptions =
        new(AllowOverflow: false, Timeout: TimeSpan.FromSeconds(10.0D));

    /// <summary>
    /// The default value for <see cref="ArithmeticOptions" />.
    /// </summary>
    public static ArithmeticOptions Default => defaultOptions;

    /// <summary>
    /// Set the default <see cref="ArithmeticOptions" />.
    /// </summary>
    /// <param name="options">
    /// The new default <see cref="ArithmeticOptions" />.
    /// </param>
    public static void SetDefault(ArithmeticOptions options)
    {
        lock (DefaultOptionsLock)
        {
            defaultOptions = options;
        }
    }
}