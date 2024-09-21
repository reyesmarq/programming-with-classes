using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else if (number < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("You did not enter a valid grade.");
        }

        Console.WriteLine($"Your letter is: {letter}");

        if (number >= 70)
        {
            Console.WriteLine("You passed! Congratulations!");
        }
        else
        {
            Console.WriteLine("You can do it better, next time!");
        }
    }
}

