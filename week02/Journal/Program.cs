using System;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();


        PromptGenerator prompt = new PromptGenerator();
        


        
       

        Journal journal = new Journal();


        int response = 0;

        while (response != 5)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save to file");
            Console.WriteLine("4. load a file");
            Console.WriteLine("5. quit");
            Console.Write("What would you like to do? ");
            response = int.Parse(Console.ReadLine());

            if (response == 1)
            {
                Entry entry = new Entry();
                entry._date = dateText;
                entry._promptText = prompt.GetRandomPrompt();
                Console.WriteLine(entry._promptText);
                Console.Write(">");
                entry._entryText = Console.ReadLine();
                journal.AddEntry(entry);
            }
            else if (response == 2)
            {
                journal.DisplayAll();
            }
            else if (response == 3)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);

            }
            else if (response == 4)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);


            }
        }

    }
}