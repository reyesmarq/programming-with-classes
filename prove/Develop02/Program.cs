using System;

class Program
{
    static void Main()
    {
        Journal journal = new();

        bool keepRunning = true;

        Console.WriteLine("Welcome to the Journal Program!");
        while (keepRunning)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");

            string option = Console.ReadLine();
            int optionInt = int.Parse(option);

            if (optionInt == 1)
            {
                Entry entry = new();

                DateTime now = DateTime.Now;
                string dateString = now.ToString("yyyy/MM/dd");
                entry._date = dateString;

                PromptGenerator generador = new();
                string question = generador.GetRandomPrompt();
                entry._promptText = question;

                Console.WriteLine(question);
                string answer = Console.ReadLine();
                entry._entryText = answer;

                journal.AddEntry(entry);
            }
            else if (optionInt == 2)
            {
                journal.DisplayAll();
            }
            else if (optionInt == 3)
            {
                Console.Write("Please enter the name of the file to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (optionInt == 4)
            {
                Console.Write("Please enter the name of the file to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (optionInt == 5)
            {
                keepRunning = false;
            }
            else
            {
                Console.WriteLine("Try again");
            }
        }
    }
}
