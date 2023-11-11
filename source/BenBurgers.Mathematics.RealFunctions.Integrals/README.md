# Ben Burgers Mathematics

## 26-XX Real Functions

### 26Axx Functions of one variable

#### 26A42 Integrals of Riemann, Stieltjes and Lebesgue type

This package provides features that involve the 26A42 Mathematics Subject Classification (MSC2020) 
concerning integrals of Riemann, Stieltjes and Lebesgue type.

##### Integrals in general

The ```BenBurgers.Mathematics.RealFunctions.Integrals.Integral``` class provides ways of implementing integrals and algorithms for their approximations.

The constructor of the class expects an argument of type ```BenBurgers.Mathematics.RealFunctions.Integrals.IIntegralAlgorithm```.\

The implementation of this interface should calculate the approximation of the integral.

##### Darboux integral

In the ```BenBurgers.Mathematics.RealFunctions.Integrals.Darboux``` namespace you may find 
an implementation of the Riemann-Darboux integral.

This integral approximates an integral's function by calculating the area under or over the function's output (depending on whether it is positive or negative respectively).

The area is approximated by taking small steps in the input value and multiplying the distance of those steps with the output of the function for the first and second values of the steps.

See [Darboux integral](https://en.wikipedia.org/wiki/Darboux_integral) on Wikipedia for a full explanation.

*Example*
```C#
var integral = new IntegralDarboux<decimal>(x => x * 2.0m);
var steps =
	new DarbouxStepsArgsSync<decimal>(
		0.0m,
		100.0m,
		0.1m,
		IntegralDarbouxMode.Lower
	);
var approximation = integral.Approximate(steps);
```

In this example, the approximation is calculated synchronously from the partition `0` through `100` with steps of `0.1`.

For more laborious approximations, it is also possible to calculate asynchronously.

*Example*
```C#
var integral = new IntegralDarboux<decimal>(x => 2.0m + x * 3.0m);
var args = new DarbouxArgsAsync<decimal>(
	new ReadOnlyMemory<Integral<decimal>.Partition>(
		new Integral<decimal>.Partition[]
		{
			new (0.0m, 50.0m),
			new (50.0m, 100.0m)
		},
	0.001m,
	IntegralDarbouxMode.Lower);
var approximation = await integral.ApproximateAsync(args);
```

In this example, the integral is split into two partitions; `0` through `50` and `50` through `100`.
When the integral is approximated, one thread for each partition calculates the approximation of the assigned partition
and when all threads are finished, the subtotals produced by each thread are summed to a grand total.

This divide and conquer approach enables utilizing multiple threads for the same integral and may speed up
calculation, especially if a larger resolution (smaller steps) is desired. For instance, in this example the step is `0.001` rather than `0.1` and may take a similar amount of time in total.