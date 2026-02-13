using System;

namespace TinyAI
{
    // Program class containing the entry point of the application
    class Program
    {
        // Main method - entry point of the program
        static void Main()
        {
            // Display welcome message and instructions
            Console.WriteLine("Welcome to TinyAI! Type 'exit' to exit.");
            
            // Control variable for the main program loop
            bool run = true;
            
            // Main loop - runs until user types 'exit'
            while (run)
            {
                // Get input from user
                Console.Write("You:\n ");
                string input = Console.ReadLine() ?? ""; // ?? handles null return value
                
                // Display prefix for AI response
                Console.Write("AI:\n ");
                
                // Check user input
                if (string.IsNullOrWhiteSpace(input))
                {
                    // Case: empty input or only whitespace
                    Console.WriteLine("Please talk anything!!");
                }
                else if (input == "exit")
                {
                    // Exit the program
                    Console.WriteLine("Bye~");
                    run = false; // End loop, exit program
                }
                else if (input.Contains("hi") || input.Contains("hello"))
                {
                    // Respond when user greets
                    Console.WriteLine("Hi there!! Nice to meet you!");
                }
                else 
                {
                    // Case: don't understand the question
                    Console.WriteLine("Sorry! I don't know...");
                }
                // TODO: You can add more patterns and smarter responses here
                // Examples:
                // - Handle questions about time, weather
                // - Integrate AI APIs (ChatGPT, Gemini, etc.)
                // - Add conversation context memory
            }
        }
    }
}
