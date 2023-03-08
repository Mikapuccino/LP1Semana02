using System;

namespace GranpaPatternSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auxiliary variables
            string question, response;

            // Ask user a question
            Console.Write("Place your question? ");
            question = Console.ReadLine();

            // Check if it is a known question and determine the
            // proper answer
            response = question switch
            {
                "How are you?" => "I'm fine, thank you",

                "What's your name?" => "Gran'pa",

                "What's your mission?" => "Destroy mankind!",

                _ => "You got me, I'm not THAT smart!",
            };

            // Answer properly
            Console.WriteLine(response);
        }
    }
}
