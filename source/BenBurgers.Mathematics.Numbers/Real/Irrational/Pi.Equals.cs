/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural.Prime;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;
using BenBurgers.Mathematics.Numbers.Real.Rational;
using System.Diagnostics.CodeAnalysis;

namespace BenBurgers.Mathematics.Numbers.Real.Irrational
{
    public readonly partial struct Pi
    {
        /// <inheritdoc />
        public bool Equals(byte other) => false;

        /// <inheritdoc />
        public bool Equals(sbyte other) => false;

        /// <inheritdoc />
        public bool Equals(ushort other) => false;

        /// <inheritdoc />
        public bool Equals(short other) => false;

        /// <inheritdoc />
        public bool Equals(uint other) => false;

        /// <inheritdoc />
        public bool Equals(int other) => false;

        /// <inheritdoc />
        public bool Equals(ulong other) => false;

        /// <inheritdoc />
        public bool Equals(long other) => false;

        /// <inheritdoc />
        public bool Equals(float other) => false;

        /// <inheritdoc />
        public bool Equals(double other) => false;

        /// <inheritdoc />
        public bool Equals(decimal other) => false;

        /// <inheritdoc/>
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            return obj switch
            {
                null => false,
                Pi => true,
                _ => false
            };
        }

        /// <inheritdoc/>
        public bool Equals(Pi other) => true;

        /// <inheritdoc/>
        public bool Equals(IPrimeNumber? other) => false;

        /// <inheritdoc/>
        public bool Equals(INaturalNumber? other) => false;

        /// <inheritdoc/>
        public bool Equals(IIntegerNumber? other) => false;

        /// <inheritdoc/>
        public bool Equals(IRationalNumber? other) => false;

        /// <inheritdoc/>
        public bool Equals(IIrrationalNumber? other)
        {
            throw new NotImplementedException();
        }
    }
}