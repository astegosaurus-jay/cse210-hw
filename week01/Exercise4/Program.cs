using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int response = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while(response != 0)
        {
            
            Console.Write("Enter a number: ");
            response = int.Parse(Console.ReadLine());
            
            if(response != 0)
            {
                numbers.Add(response);
            }
            
        }
        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"the sum is {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"the average is {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"the max number is {max}");
    }
}