using System;

class Program
{
    static void Main()
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Console.Write("Please enter your favorite number: ");
        }
        //I tryed with this loop because the simple input give an error because I cant convert the string to int 
        //I search what is the meaning of ! in this line and I found this 
        //The ! operator negates the Boolean value returned by int.TryParse. So, if int.TryParse returns true (meaning it successfully parsed the input as an integer), !true evaluates to false, and the loop exits because the condition is no longer true. On the other hand, if int.TryParse returns false (meaning it couldn't parse the input as an integer), !false evaluates to true, and the loop continues to prompt the user for input until a valid integer is entered. 
        return number;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"Hello, {userName}! Your favorite number squared is: {squaredNumber}");
    }
}
