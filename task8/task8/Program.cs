using System;

public class Program
{
    public static string Encrypt(string text, int rotation)
    {
        string encryptedText = "";

        for (int i = 0; i < text.Length; i++)
        {
            char encryptedChar = (char)(text[i] + rotation);
            encryptedText = encryptedText + encryptedChar;
        }

        return encryptedText;
    }

    public static string Decrypt(string text, int rotation)
    {
        string decryptedText = "";

        for (int i = 0; i < text.Length; i++)
        {
            char decryptedChar = (char)(text[i] - rotation);
            decryptedText = decryptedText + decryptedChar;
        }

        return decryptedText;
    }

    public static void Main()
    {
        Console.WriteLine("1. Encrypt");
        Console.WriteLine("2. Decrypt");
        Console.WriteLine("0. Exit");

        Console.Write("Enter your option: ");
        int option = Convert.ToInt32(Console.ReadLine());

        if (option == 1)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            Console.Write("Enter number of rotations: ");
            int rotation = Convert.ToInt32(Console.ReadLine());

            string encrypted = Encrypt(text, rotation);

            Console.WriteLine("Encrypted text: " + encrypted);
        }

        if (option == 2)
        {
            Console.Write("Enter encrypted text: ");
            string text = Console.ReadLine();

            Console.Write("Enter number of rotations: ");
            int rotation = Convert.ToInt32(Console.ReadLine());

            string decrypted = Decrypt(text, rotation);

            Console.WriteLine("Decrypted text: " + decrypted);
        }

        if (option == 0)
        {
            Environment.Exit(0);
        }
    }
}