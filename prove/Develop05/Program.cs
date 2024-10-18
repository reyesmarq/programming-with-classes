using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int selection;

        Console.WriteLine("Welcome to the Mindfulness Program!");

        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("[1] Start breathing activity");
            Console.WriteLine("[2] Start reflecting activity");
            Console.WriteLine("[3] Start listing activity");
            Console.WriteLine("[4] Quit");
            Console.Write("Select a choice from the menu: ");

            // TODO: ADD VALIDATION FOR USER INPUT
            selection = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (selection == 1)
            {
                string name = "Breathing";
                string description =
                    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                int duration = 60;
                BreathingActivity breathingActivity = new(name, description, duration);
                breathingActivity.Run();
            }
            if (selection == 2)
            {
                string name = "Reflecting";
                string description =
                    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                int duration = 60;
                ReflectionActivity reflectingActivity = new(name, description, duration);
                reflectingActivity.Run();
            }
            if (selection == 3)
            {
                string name = "Listing";
                string description =
                    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                int duration = 60;

                ListingActivity listingActivity = new(name, description, duration);
                listingActivity.Run();
            }
            if (selection == 4)
            {
                Console.WriteLine("Quitting program...");
            }
        } while (selection != 4);
    }
}

