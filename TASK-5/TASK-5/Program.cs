using System;

namespace Week2_Practical_task
{
    internal class task5
    {
        public static void Main()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            int words = 1;

            for (int i = 1; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    words++;
                }
            }

            Console.WriteLine("Number of words: " + words);
        }
    }
}