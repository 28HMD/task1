using System;

public class Program
{
    public static string Encrypt(string text, int rotation)
    {
        string encryptedText = "";

        foreach (char c in text)
        {
            if (char.IsUpper(c))
            {
                char encryptedChar = (char)('A' + (c - 'A' + rotation) % 26);
                encryptedText += encryptedChar;
            }
            else if (char.IsLower(c))
            {
                char encryptedChar = (char)('a' + (c - 'a' + rotation) % 26);
                encryptedText += encryptedChar;
            }
            else
            {
                encryptedText += c;
            }
        }

        return encryptedText;
    }

    public static string Decrypt(string text, int rotation)
    {
        string decryptedText = "";

        foreach (char c in text)
        {
            if (char.IsUpper(c))
            {
                char decryptedChar = (char)('A' + (c - 'A' - rotation + 26) % 26);
                decryptedText += decryptedChar;
            }
            else if (char.IsLower(c))
            {
                char decryptedChar = (char)('a' + (c - 'a' - rotation + 26) % 26);
                decryptedText += decryptedChar;
            }
            else
            {
                decryptedText += c;
            }
        }

        return decryptedText;
    }

    public static void Main()
    {
        try
        {
            Console.WriteLine("1. Encrypt");
            Console.WriteLine("2. Decrypt");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 0)
            {
                Environment.Exit(0);
            }

            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            Console.Write("Enter rotation value (1-99): ");
            int rotation = Convert.ToInt32(Console.ReadLine());

            if (rotation <= 0 || rotation >= 100)
            {
                Console.WriteLine("Rotation must be between 1 and 99.");
                return;
            }

            if (option == 1)
            {
                Console.WriteLine("Encrypted text: " + Encrypt(text, rotation));
            }
            else if (option == 2)
            {
                Console.WriteLine("Decrypted text: " + Decrypt(text, rotation));
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
        catch
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
        }
    }
}