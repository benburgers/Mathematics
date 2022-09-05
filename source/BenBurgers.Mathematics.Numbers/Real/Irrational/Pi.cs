/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers.Real.Irrational;

/// <summary>
/// Represents the number Pi (π).
/// </summary>
public readonly partial struct Pi
    : IIrrationalNumber<Pi>,
    IComparable<Pi>,
    IEquatable<Pi>
{
    private const decimal PiDecimal = 3.1415926535_8979323846_2643383279_5028841971_6939937510_5820974944_5923078164_0628620899_8628034825_3421170679M;
    private const double PiDouble = (double)PiDecimal;
    private const double PiFloat = (float)PiDecimal;

    /// <summary>
    /// The singleton instance of <see cref="Pi" />.
    /// </summary>
    public static readonly Pi Instance = new();

    /// <summary>
    /// Initializes a new instance of <see cref="Pi" />.
    /// </summary>
    public Pi()
    {
    }

    /// <inheritdoc/>
    public bool IsNegative => false;

    /// <inheritdoc/>
    public bool IsZero => false;

    /// <inheritdoc/>
    public NumberClass NumberClass =>
        NumberClass.Real
        | NumberClass.IrrationalNumbers;

    /// <inheritdoc/>
    public override int GetHashCode() => PiDecimal.GetHashCode();

    /// <inheritdoc/>
    public override string ToString() => "π";
}