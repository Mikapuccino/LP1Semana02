using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auxiliary variables
            string response, question = "";

            // Cycle repeats until user inputs "EXIT"
            while (question != "EXIT")
            {
                // Ask user a question
                Console.Write("Ask me a question: ");
                question = Console.ReadLine();

                // Check if it is a known question and determine the
                // proper answer
                response = question switch
                {
                    "What's the most important aspect of a game?" => 
                    "Sound, definitely sound",

                    "What is the meaning of life?" => "42",

                    "What do you want?" => 
                    "Your clothes, your boots and your motorcycle!",

                    "What is your purpose?" => "I pass the butter...",

                    "EXIT" => "",

                    _ => "I don't know that question",
                };

                // Answer properly
                Console.WriteLine(response);
            }
        }
    }
}
