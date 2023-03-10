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

            // Reset finalLine to modify later
            finalLine = "";

            // Cycle will repeat until height is equal to the first argument
            for (int height = 1; height < size - 1; height++)
            {
                // Cycle repeats for each line that needs to be drawn
                // Chooses the appropriate character to add based on its
                // position in the line
                for (int character = 1; character <= size; character++)
                {
                    // First character is always a #
                    if (character == 1)
                    {
                        finalLine += "#";
                    }

                    // Final character is always a #
                    else if (character == size)
                    {
                        finalLine += "#";
                    }

                    // In between the # there is always empty space
                    else
                    {
                        finalLine += " ";
                    }
                }

                Console.WriteLine(finalLine);
                finalLine = "";
            }

            for (int line = 1; line <= size; line++)
            {
                // Adds character to end of string
                finalLine += "#";
            }

            // Writes the final string properly
            Console.WriteLine(finalLine);
        }
    }
}
