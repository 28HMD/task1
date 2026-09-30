// Name: Hamad Essa Alkathery
// Module: COM326 - Dr sawsan saad
// Practical: Week 2
// Task: Methods
// Date: 30/09/2026
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

    public static int InputOption()
    {
        int option = 0;

        try
        {
            Console.Write("Enter your option: ");
            option = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }

        return option;
    }

    public static string GetMessage(int option)
    {
        switch (option)
        {
            case 0:
                return "Goodbye";

            case 1:
                return "Bonjour";

            case 2:
                return "Ola";

            case 3:
                return "Hallo";

            case 4:
                return "Ciao";

            default:
                return "Please enter a valid option";
        }
    }

    public static void Main()
    {
        int option;

        do
        {
            PrintMenu();

            option = InputOption();

            string message = GetMessage(option);

            Console.WriteLine(message);
            Console.WriteLine();

        } while (option != 0);
    }
}