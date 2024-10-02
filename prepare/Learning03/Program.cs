class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new();
        Fraction fraction2 = new(5);
        Fraction fraction3 = new(3, 4);
        Fraction fraction4 = new(1, 3);

        Console.WriteLine($"fraction 1: {fraction1.GetFractionString()}");
        Console.WriteLine($"fraction 1: {fraction1.GetDecimalFraction()}");

        Console.WriteLine($"fraction 2: {fraction2.GetFractionString()}");
        Console.WriteLine($"fraction 2: {fraction2.GetDecimalFraction()}");

        Console.WriteLine($"fraction 3: {fraction3.GetFractionString()}");
        Console.WriteLine($"fraction 3: {fraction3.GetDecimalFraction()}");

        Console.WriteLine($"fraction 4: {fraction4.GetFractionString()}");
        Console.WriteLine($"fraction 4: {fraction4.GetDecimalFraction()}");
    }
}
