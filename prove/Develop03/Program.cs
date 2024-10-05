class Program
{
    static void Main(string[] args)
    {
        string selection;
        Reference reference = new("Proverbs", 3, 3, 6);
        string referenceText =
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new(reference, referenceText);

        do
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            selection = Console.ReadLine();

            Random random = new();
            int numbertohide = random.Next(1, 4);
            scripture.HideRandomWords(numbertohide);
        } while (selection != "quit" && !scripture.IsCompletelyHidden());
    }
}

