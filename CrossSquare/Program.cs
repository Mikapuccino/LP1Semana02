using System;

namespace CrossSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auxiliary variables

            int size = int.Parse(args[0]);
            string finalLine = "";
            
            // Cycle will repeat until size is bigger than the first argument
            for (int line = 1; line <= size; line++)
            {
                // Adds character to end of string
                finalLine += "#";
            }

            // Writes the first string properly
            Console.WriteLine(finalLine);
        }
    }
}
