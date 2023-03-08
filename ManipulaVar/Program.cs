using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Converts first argument into an int and increments it
            int x = int.Parse(args[0]);
            x++;
            Console.WriteLine($"{x}");

            // Converts first argument into an int to become the original
            // value again and decrements it
            x = int.Parse(args[0]);
            --x;
            Console.WriteLine($"{x}");
        }
    }
}
