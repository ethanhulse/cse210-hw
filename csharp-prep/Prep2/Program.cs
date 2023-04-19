using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage:");
        int gradePercentage = Convert.ToInt32(Console.ReadLine());

        string letter;
        if (gradePercentage >= 90) {
            letter = "A";
        } else if (gradePercentage >= 80) {
            letter = "B";
        } else if (gradePercentage >= 70) {
            letter = "C";
        } else if (gradePercentage >= 60) {
            letter = "D";
        } else {
            letter = "F";
        }

        Console.WriteLine("Your letter grade is: " + letter);

        if (gradePercentage >= 70) {
            Console.WriteLine("Congratulations! You passed the course.");
        } else {
            Console.WriteLine("Better luck next time. Keep trying!");
        }

        // Stretch Challenge
        string sign;
        int lastDigit = gradePercentage % 10;
        if (letter == "A" && lastDigit >= 7) {
            sign = "+";
        } else if (letter == "B" && lastDigit >= 7) {
            sign = "+";
        } else if (letter == "C" && lastDigit >= 7) {
            sign = "+";
        } else if (letter == "D" && lastDigit >= 7) {
            sign = "+";
        } else if (letter == "A" && lastDigit < 3) {
            sign = "-";
        } else if (letter == "B" && lastDigit < 3) {
            sign = "-";
        } else if (letter == "C" && lastDigit < 3) {
            sign = "-";
        } else if (letter == "D" && lastDigit < 3) {
            sign = "-";
        } else {
            sign = "";
        }

        // Handle exceptional cases
        if (letter == "A" && lastDigit >= 3 && lastDigit <= 6) {
            letter += "-";
        } else if (letter == "F" && (lastDigit >= 3 || lastDigit <= 6)) {
            letter = "F";
        }

        Console.WriteLine("Your final grade is: " + letter + sign);
    }
}