using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        Console.Write("What is score?: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";

        string signScore = "";


        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 70)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }

        int secondDigit = grade % 10;

        if (secondDigit >= 7)
        {
            signScore = "+";
        }

        else if (secondDigit > 3)
        {
            signScore = "";
        }

        else if (secondDigit <= 3)
        {
            signScore = "-";
        }

        else if (letter == "F")
        {
            signScore = "";
        }

        if (grade >= 70)
        {
            Console.WriteLine($"Congratulatons you pass the class with '{signScore}{letter}'!");
        }

        else
        {
            Console.WriteLine($"Your grade is '{letter}' keep trying, you can do it the next time.");
        }
    }
}   