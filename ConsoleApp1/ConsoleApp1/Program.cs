using System;

public class Program
{
    public static void PrintMenu()
    {
        Console.WriteLine("Please enter a valid option from below:");
        Console.WriteLine("1. Hello in French?");
        Console.WriteLine("2. Hello in Spanish?");
        Console.WriteLine("3. Hello in German?");
        Console.WriteLine("4. Hello in Italian?");
        Console.WriteLine("0. Exit application");
    }

    public static void Main()
    {
        PrintMenu();
    }
}