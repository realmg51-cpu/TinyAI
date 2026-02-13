using System;
namespace TinyAI
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to TinyAI! Type 'exit' to exit.");
            bool run = true;
            while (run)
            {
                Console.Write("You:\n ");
                string input = Console.ReadLine() ?? "";
                Console.Write("AI:\n ");
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please talk anything!!");
                }
                else if (input == "exit")
                {
                    Console.WriteLine("Bye~");
                }
                else if (input.Contains("hi") || input.Contains("hello"))
                {
                    Console.WriteLine("Hi there!! Nice to meet you!");
                }
                else 
                {
                    Console.WriteLine("Sorry! I don't know...");
                }
                //... You can add more.
            }
        }
    }
}
