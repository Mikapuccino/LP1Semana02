using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Height: ");
            string h = Console.ReadLine();
            double height = double.Parse(h);

            Console.WriteLine("Radius: ");
            string r = Console.ReadLine();
            double radius = double.Parse(r);

            double V = Math.PI * Math.Pow(radius, 2) * height;
            double S = (2 * Math.PI) * (radius * (radius + height));
            Console.WriteLine($"Volume = {V}");
            Console.WriteLine($"Surface = {S}");
        }
    }
}
