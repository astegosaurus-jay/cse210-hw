using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromtUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program");
        }

        static string PromtUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string response = Console.ReadLine();
            int number = int.Parse(response);
            return number;
        }

        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        static void DisplayResult(string name, int squared)
        {
            Console.WriteLine($"{name}, the square of your number is {squared}");

        }
    
}