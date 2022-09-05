# Ben Burgers Mathematics: Numbers

This package is part of the `Mathematics` solution by Ben Burgers and contributors.

## Package Description

This package provides features for the field of Number Theory in Mathematics, as well as ordinary number operations.

## Software Design Considerations

### True mathematics

The code is designed with mathematics in mind. This means that an integer number is truly an integer number,
not the integer number that one might be used to in programming, which may be represented by 32 bits or 64 bits depending on your processor architecture.
For instance, if a number can be infinite in mathematics, it can be (theoretically) infinite in code, only limited by the machine that runs it.

### Infinity

The numbers in this package can theoretically be infinite, only limited by the memory and processing limitations of the machine that runs it.
This is solved by creating a binary representation of the number in a similar way to how it has been solved in `System.Numerics.BigInteger`.
However, even a `BigInteger` has its limitations, as it is represented by an array that is indexed by a 32-bit integer.

### Performance

The difference with normal computational mathematics in this package is that it uses linked lists, which may theoretically go on forever.

With performance in mind, this list contains native integers, so in a 32-bit system, the list contains 32-bit integer items
and in a 64-bit system, the list contains 64-bit integer items, rather than bytes.
As a result, during computation, the entire integer will be used, rather than split into bytes.
This may cost some more insignificant memory in case of very small numbers, but it should increase performance of computations in medium to large numbers.

Obviously, a linked list also has more memory overhead than an ordinary array, but it is not limited by a simple index.
The trade-off is that indexes are not supported, though the number should always be treated in its entirety anyway.

To prevent computations that may take too long, arithmetic operations must be limited by options that are provided when requesting evaluation of the operation.

## Versions

### 0.1.0-alpha

Warning: this is an unstable version, prone to changes.

#### Prime Numbers

Added `PrimeNumber` to represent prime numbers. No other numbers may be `PrimeNumber`.

##### Primality Tests

Added `PrimalityTester` that tests any integer number for primality, using an algorithm of your choosing.

#### Natural Numbers

Added `NaturalNumber` to represent a number that is natural.
Numbers may be converted from and to `NaturalNumber` provided that they are positive integer numbers. This includes zero.

#### Integer Numbers

Added `IntegerNumber` to represent an integer.
Numbers may be converted from and to `IntegerNumber` provided that they are integer numbers. This includes zero.

#### Fractions

Added `Fraction` to represent a fraction.
Numbers may be converted from and to `Fraction` provided that they are real, rational numbers.

#### Approximations

Added `Approximation` to represent a real, rational number approximated by a number and a power of ten.
Numbers may be converted from and to `Approximation`, provided that they are real numbers.

#### Arithmetic

All supported number classes may perform arithmetic. Arithmetic is abstracted in their own code structures.
For example, an addition is represented by `Addition<TLeft,TRight>`. The two type arguments are the types of the numbers in the addition.