using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auxiliary variables

            int size = args[0];
            int lineSize = 1;
            char symbol = args[1];
            string finalLine = "";
            
            // Cycle will repeat until size is bigger than the first argument
            for (int line = 1; line <= size; line++)
            {
                finalLine += symbol;
                Console.WriteLine(finalLine);
                
                // Cycle will repeat until the size of the line is bigger
                // than the number of the line, ex: line 2 has a size of 2
                //while (lineSize <= line)
                //{
                    // Adds the symbol chosen to the end of the string
                    // a number of times equal to the number of the line
                //    finalLine += symbol;
                //    lineSize++;
                //}

                // Writes the line with correct amount of characters
                //Console.WriteLine(finalLine);

                // String resets to properly write the next line
                //finalLine = "";
            }
        }
    }
}
