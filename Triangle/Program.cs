using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auxiliary variables

            int size = int.Parse(args[0]);
            char symbol = char.Parse(args[1]);
            string finalLine = "";
            
            // Cycle will repeat until size is bigger than the first argument
            for (int line = 1; line <= size; line++)
            {
                // Adds character to end of string and writes the new string
                finalLine += symbol;
                Console.WriteLine(finalLine);
            }
        }
    }
}
