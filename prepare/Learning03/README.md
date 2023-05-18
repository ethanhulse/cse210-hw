# Fraction Program

This program demonstrates the Fraction class, which represents fractions and provides methods to manipulate and retrieve information about them.

## Fraction.cs

The `Fraction.cs` file contains the implementation of the `Fraction` class. It defines the attributes, constructors, getters, setters, and methods related to fractions.

### Class Structure

The `Fraction` class has the following structure:

```csharp
public class Fraction
{
    // Attributes
    private int numerator;
    private int denominator;

    // Constructors
    public Fraction();
    public Fraction(int numerator);
    public Fraction(int numerator, int denominator);

    // Getters and Setters
    public int GetNumerator();
    public void SetNumerator(int numerator);
    public int GetDenominator();
    public void SetDenominator(int denominator);

    // Fractional and Decimal Representations
    public string GetFractionString();
    public double GetDecimalValue();
}
```

### Constructors
The `Fraction` class provides three constructors:

```csharp
public Fraction(): Initializes the fraction to 1/1 by default.
public Fraction(int numerator): Initializes the fraction with the given numerator and a denominator of 1.
public Fraction(int numerator, int denominator): Initializes the fraction with the given numerator and denominator.
```
### Getters and Setters
The Fraction class includes getter and setter methods for both the numerator and denominator attributes. These methods allow retrieving and modifying the values of the fraction.

### Fractional and Decimal Representations
The Fraction class provides two methods to return representations of the fraction:

```csharp
public string GetFractionString(): Returns a string representation of the fraction in the form "numerator/denominator".
public double GetDecimalValue(): Calculates and returns the decimal representation of the fraction as a double value.
```

###`Program.cs`
The `Program.cs` file serves as the entry point for the program. It demonstrates the usage of the Fraction class by creating instances of fractions, calling methods, and displaying the results.