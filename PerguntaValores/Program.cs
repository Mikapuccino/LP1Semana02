using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks for a height and adds it to a variable
            Console.WriteLine("Height: ");
            string h = Console.ReadLine();
            double height = double.Parse(h);

            // Asks for a radius and adds it to a variable
            Console.WriteLine("Radius: ");
            string r = Console.ReadLine();
            double radius = double.Parse(r);

            // Calculates volume first and surface area next and
            // adds them to their respective variables
            double V = Math.PI * Math.Pow(radius, 2) * height;
            double S = (2 * Math.PI) * (radius * (radius + height));

            // Writes the final volume and surface area
            Console.WriteLine($"Volume = {V}");
            Console.WriteLine($"Surface = {S}");
        }
    }
}
