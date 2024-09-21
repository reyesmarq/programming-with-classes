using System;

class Program
{
    static void Main(string[] args)
    {
        displayMessage();
        string userName = nameOfUser();
        int userNumber = getUserNumber();
        int squaredNumber = squareOfNumber(userNumber);
        allResult(userName, squaredNumber);
    }

    static void displayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string nameOfUser()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int getUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int squareOfNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void allResult(string name, int square)
    {
        Console.WriteLine($"{name}, The square of your number is {square}");
    }
}

