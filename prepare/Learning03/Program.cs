using System;

class Program
{
    static void Main()
    {
        Fraction fraction1 = new Fraction();  // Using the first constructor (1/1)
        Console.WriteLine(fraction1.GetFractionString());  // Output: 1/1
        Console.WriteLine(fraction1.GetDecimalValue());  // Output: 1.0

        Fraction fraction2 = new Fraction(5);  // Using the second constructor (5/1)
        Console.WriteLine(fraction2.GetFractionString());  // Output: 5/1
        Console.WriteLine(fraction2.GetDecimalValue());  // Output: 5.0

        Fraction fraction3 = new Fraction(3, 4);  // Using the third constructor (3/4)
        Console.WriteLine(fraction3.GetFractionString());  // Output: 3/4
        Console.WriteLine(fraction3.GetDecimalValue());  // Output: 0.75

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());  // Output: 1/3
        Console.WriteLine(fraction4.GetDecimalValue());  // Output: 0.3333333333333333
    }
}
