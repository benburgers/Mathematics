/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Calculus.Integrals.Darboux;

public sealed partial class IntegralDarboux<TNumber>
{
    private readonly struct ThreadState
    {
        public readonly Integral<TNumber>.IntegralFunction func;
        public readonly TNumber start;
        public readonly TNumber end;
        public readonly TNumber step;
        public readonly IntegralDarbouxMode mode;
        public readonly CancellationToken cancellationToken;

        public ThreadState(
            Integral<TNumber>.IntegralFunction func,
            TNumber start,
            TNumber end,
            TNumber step,
            IntegralDarbouxMode mode,
            CancellationToken cancellationToken)
        {
            this.func = func;
            this.start = start;
            this.end = end;
            this.step = step;
            this.mode = mode;
            this.cancellationToken = cancellationToken;
        }
    }
}
