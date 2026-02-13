using System; // Import the System namespace for basic functionality like Console

namespace TinyAI // Define a namespace to organize the code
{
    // Program class containing the entry point of the application
    class Program // Declare the main class
    {
        // Main method - entry point of the program
        static void Main() // Declare the main method where program execution begins
        {
            // Display welcome message and instructions
            Console.WriteLine("Welcome to TinyAI! Type 'exit' to exit.");
            
            // Control variable for the main program loop
            bool run = true;
            
            // Main loop - runs until user types 'exit'
            while (run) // Continue looping while run is true
            {
                // Get input from user
                Console.Write("You: \n "); // Display prompt for user input
                string input = Console.ReadLine()?.ToLower().Trim() ?? ""; // Read user input, convert to lowercase, trim whitespace, handle null with empty string
                
                // Display prefix for AI response
                Console.Write("AI: \n ");
                
                // Check user input
                if (string.IsNullOrWhiteSpace(input)) // Check if input is null, empty, or whitespace (Note: string.IsNullOrExpection appears to be a typo)
                {
                    // Case:  empty input or only whitespace
                    Console.WriteLine("Please talk anything!!");
                }
                else if (input == "exit") // Check if user wants to exit
                {
                    // Exit the program
                    Console.WriteLine("Bye~");
                    run = false; // End loop,  exit program
                }
                else if (input.Contains("hi") || input.Contains("hello")) // Check if input contains greeting words
                {
                    // Respond when user greets
                    Console.WriteLine("Hi there!! Nice to meet you!");
                }
                else if (input.Contains("hey")) // Check if input contains "hey"
                {
                    // Response while input contains 'hey'
                    Console.WriteLine("Yo! What's up? How can I help you?");
                }
                else if (input.Contains("hmm")) // Check if input contains "hmm"
                {
                    Console.WriteLine("Hmm... What are you thinking for?");
                }
                else // Handle all other cases
                {
                    // Case:  don't understand the question
                    Console.WriteLine("Sorry! I don't know...");
                }
            }
        }
    }
}
