# Introduction

Hi there, my name is Ben Burgers and I am a software engineer.
It's great to find you here.

The goal of this project is to formalize everything that is currently known in mathematics into code.
This way, developing applications and features that require mathematics will be much more convenient.
And for developers (including me) it is a great way to learn mathematics, too.

Currently, the code is still in early development, so it is not yet recommended to use these packages in a production environment.
Features may change, may move, may be expanded or may disappear entirely, until a first full release is published.

If you have any suggestions for improving the code, or if you have noticed any bugs, please feel free to contact me
or to make a pull request. Thank you.

# Architecture

## Processor

The code is developed with different processor architectures in mind.
For instance, the storage of large numbers is realized by using the native integer (`nint` and `nuint`) 
to ensure either 32 bits or 64 bits (depending on the host system) are put to full use when performing calculations.
Also, where applicable (such as bit shifts), the code must check the endianness of the processor's byte order and behave accordingly.

# Code Style

## Sorting

Types (such as in properties) and operations (such as methods/functions) on types with more specificity are sorted before types with less specificity.

For example: a natural number can always be converted to an integer number, but an integer number may not always be converted to a natural number.
So the natural number precedes the integer number.
By sorting in this order, the code prefers specificity over generality.

Likewise, primitive types are sorted before the types from this solution.
So an `int` precedes an `IntegerNumber` as well as `NaturalNumber`.

# Testing

Code is tested automatically before being published. The `xUnit` suite enables the unit test projects to perform the testing.
An optimal code coverage is preferred, to ensure each piece of code is working properly. Priority will be given to more significant operations.

# Packages

Packages are created according to the various fields in maths. I.e. for Number Theory, we have the `BenBurgers.Mathematics.Numbers` package. 
For geometry, we have the `BenBurgers.Mathematics.Geometry` package, and so on.

If circular dependencies start to emerge, interfaces must be designed to mediate between them and published in a separate package.
Unless there is a more generic way (without loss of functionality or accuracy) to solve the problem while avoiding to bind packages.

Please refer to the `README.md` file of the project for more details.

## Overview

### BenBurgers.Mathematics.Algebra

This is a planned package.

#### BenBurgers.Mathematics.Algebra.Graphics

This is a planned package.

### BenBurgers.Mathematics.Calculus

This is a planned package.

#### BenBurgers.Mathematics.Calculus.Graphics

This is a planned package.

### BenBurgers.Mathematics.Discrete

This is a planned package.
It may include:
- Combinatorics
- Graph theory and hypergraphs
- Cryptography (although this may merit its own package)
- Matroid theory
etc.

#### BenBurgers.Mathematics.Discrete.Graphics

This is a planned package.

### BenBurgers.Mathematics.Geometry

This is a planned package.

#### BenBurgers.Mathematics.Geometry.Graphics

This is a planned package.

### BenBurgers.Mathematics.Logic

This is a planned package.

#### BenBurgers.Mathematics.Logic.Expressions

LINQ expressions for logic.

#### BenBurgers.Mathematics.Logic.Graphics

This is a planned package.

### BenBurgers.Mathematics.Numbers

This is the package for the field of Number Theory. It enables modelling, manipulating, reporting and reflecting on numbers.
Although arithmetic may be considered a field of its own, arithmetic is also included in this package, considering the relations between numbers.
If, however, arithmetic in this package is further developed, it may branch out into its own package.
For mathematics, this may be one of the most basic packages in this solution.

#### BenBurgers.Mathematics.Numbers.Graphics

This is a planned package.

### BenBurgers.Mathematics.Statistics

This is a planned package.

#### BenBurgers.Mathematics.Statistics.Graphics

This is a planned package.

## Dependencies

### BenBurgers.Mathematics.Algebra

- `BenBurgers.Mathematics.Numbers`

### BenBurgers.Mathematics.Algebra.Graphics

- `BenBurgers.Mathematics.Algebra`
- `BenBurgers.Mathematics.Numbers`

### BenBurgers.Mathematics.Calculus

- `BenBurgers.Mathematics.Numbers`

### BenBurgers.Mathematics.Calculus.Graphics

- `BenBurgers.Mathematics.Calculus`
- `BenBurgers.Mathematics.Numbers`

### BenBurgers.Mathematics.Discrete

- `BenBurgers.Mathematics.Numbers`

### BenBurgers.Mathematics.Discrete.Graphics

- `BenBurgers.Mathematics.Discrete`
- `BenBurgers.Mathematics.Numbers`

### BenBurgers.Mathematics.Geometry

- `BenBurgers.Mathematics.Numbers`

### BenBurgers.Mathematics.Geometry.Graphics

- `BenBurgers.Mathematics.Geometry`
- `BenBurgers.Mathematics.Numbers`

### BenBurgers.Mathematics.Logic

None so far.

### BenBurgers.Mathematics.Logic.Expressions

- `BenBurgers.Mathematics.Logic`

### BenBurgers.Mathematics.Logic.Graphics

- `BenBurgers.Mathematics.Logic`

### BenBurgers.Mathematics.Numbers

None so far.

### BenBurgers.Mathematics.Numbers.Graphics

- `BenBurgers.Mathematics.Numbers`

### BenBurgers.Mathematics.Statistics

- `BenBurgers.Mathematics.Numbers`

### BenBurgers.Mathematics.Statistics.Graphics

- `BenBurgers.Mathematics.Numbers`
- `BenBurgers.Mathematics.Statistics`