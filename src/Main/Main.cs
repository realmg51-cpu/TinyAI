using System;

namespace TinyAI
{
    class Program
    {
        static void Main()
        {
            Welcome(); // Cần dấu chấm phẩy và viết hoa chữ cái đầu (theo chuẩn C#)
            Logic();   // Cần dấu chấm phẩy
        }

        static void Welcome()
        {
            Console.WriteLine("=== Welcome to TinyAI! ===");
            Console.WriteLine("(Type 'exit' to quit)\n");
        }

        static void Logic()
        {
            bool run = true;
            while (run)
            {
                Console.Write("You: ");
                string input = Console.ReadLine()?.Trim()?.ToLower() ?? "";
                Console.Write("AI:");
                if (input == "exit")
                {
                    run = false;
                    Console.WriteLine("Goodbye! 👋");
                }
                else if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Sorry,you didn't talk anything!");
                }
                else if (input.Contains("hi") || input.Contains("hello"))
                {
                  Console.WriteLine("hello! How are you today?");
                }
                else
                {
                    Console.WriteLine("AI: I'm still learning, but I heard you!");
                }
                Console.WriteLine();
            }
        }
    }
}
