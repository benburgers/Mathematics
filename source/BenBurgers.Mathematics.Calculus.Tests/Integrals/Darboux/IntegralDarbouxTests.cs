/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Calculus.Integrals;
using BenBurgers.Mathematics.Calculus.Integrals.Darboux;
using System.Numerics;

namespace BenBurgers.Mathematics.Calculus.Tests.Integrals.Darboux;

public sealed class IntegralDarbouxTests
{
    public static readonly IEnumerable<object?[]> DarbouxTestCases =
        new[]
        {
            new object?[]
            {
                new IntegralDarboux<decimal>(i => i + 1.0m),
                new SyncArgs<decimal>(
                    0.0m,
                    100.0m,
                    0.1m,
                    IntegralDarbouxMode.Lower),
                5095.00m
            },
            new object?[]
            {
                new IntegralDarboux<decimal>(i => i + 1.0m),
                new SyncArgs<decimal>(
                    0.0m,
                    100.0m,
                    0.01m,
                    IntegralDarbouxMode.Lower),
                5099.5000m
            },
            new object?[]
            {
                new IntegralDarboux<decimal>(i => i + 1.0m),
                new SyncArgs<decimal>(
                    0.0m,
                    100.0m,
                    0.001m,
                    IntegralDarbouxMode.Lower),
                5099.950000m
            },
            new object?[]
            {
                new IntegralDarboux<decimal>(i => i + 1.0m),
                new SyncArgs<decimal>(
                    -50.0m,
                    50.0m,
                    0.001m,
                    IntegralDarbouxMode.Upper),
                100.050000m
            }
        };

    [Theory(DisplayName = "An integral should correctly calculate its result using the Darboux algorithm.")]
    [MemberData(nameof(DarbouxTestCases))]
    public void DarbouxTest<TNumber>(
        IntegralDarboux<TNumber> integral,
        SyncArgs<TNumber> args,
        TNumber expected)
        where TNumber : INumber<TNumber>
    {
        var actual = integral.Approximate(args);
        Assert.Equal(expected, actual);
    }

    public static readonly IEnumerable<object?[]> DarbouxAsyncTestCases =
        new[]
        {
            new object?[]
            {
                new IntegralDarboux<decimal>(i => i + 1.0m),
                new AsyncArgs<decimal>(
                    new ReadOnlyMemory<Integral<decimal>.Partition>(
                        new Integral<decimal>.Partition[]
                        {
                            new(0.0m, 100.0m)
                        }),
                    0.001m,
                    IntegralDarbouxMode.Lower),
                5099.950000m,
                5099.950000m
            },
            new object?[]
            {
                new IntegralDarboux<decimal>(i => i + 1.0m),
                new AsyncArgs<decimal>(
                    new ReadOnlyMemory<Integral<decimal>.Partition>(
                        new Integral<decimal>.Partition[]
                        {
                            new(0.0m, 50.0m),
                            new(50.0m, 100.0m)
                        }),
                    0.001m,
                    IntegralDarbouxMode.Lower),
                5099.950000m,
                5099.959999m
            },
            new object?[]
            {
                new IntegralDarboux<decimal>(i => i + 1.0m),
                new AsyncArgs<decimal>(
                    new ReadOnlyMemory<Integral<decimal>.Partition>(
                        new Integral<decimal>.Partition[]
                        {
                            new(0.0m, 10.0m),
                            new(10.0m, 20.0m),
                            new(20.0m, 30.0m),
                            new(30.0m, 40.0m),
                            new(40.0m, 50.0m),
                            new(50.0m, 60.0m),
                            new(60.0m, 70.0m),
                            new(70.0m, 80.0m),
                            new(80.0m, 90.0m),
                            new(90.0m, 100.0m)
                        }),
                    0.0001m,
                    IntegralDarbouxMode.Lower),
                5099.99500000m,
                5099.99599999m
            },
            new object?[]
            {
                new IntegralDarboux<decimal>(i => i + 1.0m),
                new AsyncArgs<decimal>(
                    new ReadOnlyMemory<Integral<decimal>.Partition>(
                        new Integral<decimal>.Partition[]
                        {
                            new(-50.0m, -40.0m),
                            new(-40.0m, -30.0m),
                            new(-30.0m, -20.0m),
                            new(-20.0m, -10.0m),
                            new(-10.0m, 0.0m),
                            new(0.0m, 10.0m),
                            new(10.0m, 20.0m),
                            new(20.0m, 30.0m),
                            new(30.0m, 40.0m),
                            new(40.0m, 50.0m)
                        }),
                    0.0001m,
                    IntegralDarbouxMode.Upper),
                100.00000000m,
                100.00500000m
            }
        };

    [Theory(DisplayName = "An integral should correctly calculate its result using the Darboux algorithm [asynchronously].")]
    [MemberData(nameof(DarbouxAsyncTestCases))]
    public async Task DarbouxTestAsync<TNumber>(
        IntegralDarboux<TNumber> integral,
        AsyncArgs<TNumber> args,
        TNumber expectedMin,
        TNumber expectedMax)
        where TNumber : INumber<TNumber>
    {
        var actual = await integral.ApproximateAsync(args);
        Assert.InRange(actual, expectedMin, expectedMax);
    }
}
