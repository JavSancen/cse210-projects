using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter numbers (enter 0 to finish):");
        while (true)
        {
            Console.Write("Enter a number or 0 to finish: ");
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input == 0)
                    break;

                numbers.Add(input);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers entered.");
        }
        else
        {
            Console.WriteLine("List of Numbers: " + string.Join(", ", numbers));
            int sum = numbers.Sum();
            double average = numbers.Average();
            int smallest = numbers.Where(x => x > 0).DefaultIfEmpty(0).Min(); 
            // Minimum positive number
            //numbers is assumed to be a collection, such as an array or a list, containing integers.
            //Where(x => x > 0) is a LINQ (Language Integrated Query) extension method. It's used to filter the elements in the numbers collection based on a condition. In this case, it's selecting elements where x (each element in the collection) is greater than 0.
            //DefaultIfEmpty(0) is another LINQ method. It ensures that there's at least one element in the collection, and if the collection is empty, it inserts a default value of 0. This is done to avoid an exception when calling .Min() on an empty collection.
            //Min() is a LINQ method that finds the minimum value among the elements in the collection.
            int largest = numbers.Max();

            Console.WriteLine("Sum of Numbers: " + sum);
            Console.WriteLine("Average of Numbers: " + average);
            Console.WriteLine("Smallest Positive Number: " + (smallest > 0 ? smallest.ToString() : "None"));
            Console.WriteLine("Largest Number: " + largest);
        }
    }
}