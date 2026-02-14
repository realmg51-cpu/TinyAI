using System;

namespace TinyAI 
{
    class Program 
    {
        static void Main() 
        {
            // Support for Emojis in some consoles
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Console.WriteLine("✨ Welcome to TinyAI! Type 'exit' to say goodbye. ✨");

            bool isRunning = true;

            while (isRunning) 
            {
                // Coloring the prompt for a cooler look! 🎨
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine()?.ToLower().Trim() ?? "";

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("AI: ");
                Console.ResetColor();

                // Using Modern Pattern Matching for cleaner code
                string response = input switch
                {
                    "" => "Don't be so quiet, talk to me! 😶",
                    "exit" => "Goodbye! I'm going to take a nap now~ 😴",
                    var s when s.Contains("hi") || s.Contains("hello") => "Hi there!! Nice to meet you! 👋",
                    var s when s.Contains("hey") => "Yo! What's up? How can I help you? 😎",
                    var s when s.Contains("hmm") => "Hmm... Thinking hard? Need me to think for you? 🤔",
                    var s when s.Contains("stupid") => "I'm not stupid, I'm just saving my energy! 🧠⚡",
                    _ => "Too hard for me... I haven't learned that part yet! 😅"
                };

                Console.WriteLine(response);

                if (input == "exit") isRunning = false;
            }
        }
    }
}
