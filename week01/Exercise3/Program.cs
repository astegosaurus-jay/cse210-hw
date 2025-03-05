using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess = 0;
        while (guess != number)
        {
            Console.Write("Guess the magic number: ");
            string response = Console.ReadLine();
            guess = int.Parse(response);
            if (guess > number)
            {
                Console.WriteLine("lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("higher");
            }
            else if (guess == number)
            {
                Console.WriteLine("correct");
            }
        }
    }
}