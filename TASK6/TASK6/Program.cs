using System;

public class Program
{
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
        Console.Write("Enter encrypted text: ");
        string text = Console.ReadLine();

        Console.Write("Enter number of rotations: ");
        int rotation = Convert.ToInt32(Console.ReadLine());

        string decrypted = Decrypt(text, rotation);

        Console.WriteLine("Encrypted text: " + text);
        Console.WriteLine("Decrypted text: " + decrypted);
    }
}