/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic;
using BenBurgers.Mathematics.Numbers.Arithmetic.Prime;
using BenBurgers.Mathematics.Numbers.Arithmetic.Sequence;
using BenBurgers.Mathematics.Numbers.Sequence;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural.Prime;

/// <summary>
/// Represents a Prime Number.
/// </summary>
public readonly partial struct PrimeNumber
    : IPrimeNumber
{
    private readonly NumberSequence sequence;
    private readonly NaturalNumber asNatural;

    /// <summary>
    /// Initializes a new instance of <see cref="PrimeNumber" />.
    /// </summary>
    /// <param name="sequence">
    /// The binary number sequence.
    /// </param>
    /// <exception cref="NumberNotPrimeException">
    /// A <see cref="NumberNotPrimeException" /> if a primality test fails on <paramref name="sequence" />.
    /// </exception>
    private PrimeNumber(NumberSequence sequence)
    {
        var asNatural = new NaturalNumber(sequence); // TODO PrimalityTester accepts sequences.
        var isPrime =
            PrimalityTester
                .IsPrimeAsync(asNatural, PrimalityTester.Algorithm.SixKPlusOrMinusOne, ArithmeticOptions.Default)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
        if (!isPrime)
            throw new NumberNotPrimeException();
        this.sequence = sequence;
        this.asNatural = new NaturalNumber(sequence);
    }

    /// <inheritdoc/>
    public bool IsEven => this.asNatural.IsEven;

    /// <inheritdoc/>
    /// <remarks>
    /// Prime numbers are never negative.
    /// </remarks>
    public bool IsNegative => false;

    /// <inheritdoc/>
    /// <remarks>
    /// Prime numbers are never zero.
    /// </remarks>
    public bool IsZero => false;

    /// <inheritdoc/>
    public NumberClass NumberClass =>
        NumberClass.Real
        | NumberClass.Rational
        | NumberClass.Integer
        | NumberClass.Natural
        | NumberClass.Prime;

    /// <inheritdoc />
    public override int GetHashCode()
        => this.sequence.Start.GetHashCode();

    /// <summary>
    /// Parses a <see cref="PrimeNumber" /> from a <see cref="string" /> representation.
    /// </summary>
    /// <param name="primeString">
    /// The <see cref="string" /> representation of a <see cref="PrimeNumber" />.
    /// </param>
    /// <param name="options">
    /// The options for arithmetic operations.
    /// </param>
    /// <param name="cancellationToken">
    /// The cancellation token.
    /// </param>
    /// <returns>
    /// The parsed <see cref="PrimeNumber" />.
    /// </returns>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the operation exceeded the timeout.
    /// </exception>
    /// <exception cref="OperationCanceledException">
    /// A <see cref="OperationCanceledException" /> is thrown if the operation was canceled.
    /// </exception>
    public static async Task<PrimeNumber> ParseAsync(
        string primeString,
        ArithmeticOptions options,
        CancellationToken cancellationToken = default)
    {
        var sequence = await SequenceArithmetic.ParseAsync(primeString, options, cancellationToken);
        return new(sequence);
    }

    /// <summary>
    /// Returns a <see cref="string" /> representation of <see cref="PrimeNumber" />.
    /// </summary>
    /// <returns>
    /// The <see cref="string" /> representation of <see cref="PrimeNumber" />.
    /// </returns>
    public override string ToString()
        => SequenceArithmetic.ToString(
            typeof(PrimeNumber),
            this.sequence,
            ArithmeticOptions.Default);

    NumberSequence IIntegerNumber.Sequence => this.sequence;
}