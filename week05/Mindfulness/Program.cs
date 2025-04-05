using System;

class Program
{
    static void Main(string[] args)
    {
        int input = 0;
        

        while (input != 4)
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start Reflecting activity");
            Console.WriteLine("  3. Start listing activity ");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = int.Parse(Console.ReadLine());

            if(input == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                Console.Clear();
                
                breathingActivity.DisplayEndingMessage();
                breathingActivity.ShowSpinner(5);
                Console.Clear();
            }


            if (input == 2)
            {
               ReflectingActivity reflectingActivity = new ReflectingActivity();
               reflectingActivity.Run();
               Console.Clear();

               reflectingActivity.DisplayEndingMessage();
               reflectingActivity.ShowSpinner(5);
               Console.Clear();
            }

            if (input == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                Console.Clear();

                listingActivity.DisplayEndingMessage();
                listingActivity.ShowSpinner(5);
                Console.Clear();
            }
        }
    }
}