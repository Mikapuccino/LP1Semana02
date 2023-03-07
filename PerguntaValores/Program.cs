using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = float.Parse(args[0]);
            double r = float.Parse(args[1]);

            double V = Math.PI * Math.Pow(r, 2) * a;
            double S = (2 * Math.PI) * (r * (r + a));
            Console.WriteLine($"Volume = {V}");
            Console.WriteLine($"Surface = {S}");
        }
    }
}
