using System;

namespace TinyAI
{
    public static class ChatCore
    {
        // Display welcome message when program starts
        public static void Welcome()
        {
            Console.WriteLine("=== Welcome to TinyAI! ===");
            Console.WriteLine("(Type 'exit' to quit)\n");
        }

        // Helper method to print AI responses with prefix
        public static void Say(string message)
        {
            Console.WriteLine("AI: " + message);
        }

        // Main chat logic with if-else conditions
        public static void Logic()
        {
            bool run = true;  // Control the chat loop
            
            while (run)
            {
                // Get user input
                Console.Write("You: ");
                string userInput = Console.ReadLine()?.Trim() ?? "";
                
                // Convert to lowercase for easier comparison
                string lowerInput = userInput.ToLower();
                
                // Check for exit command first
                if (lowerInput == "exit")
                {
                    isRunning = false;  // Stop the loop
                    Say("Goodbye! 👋");
                }
                
                // Check if input is empty or just spaces
                else if (string.IsNullOrEmpty(lowerInput))
                {
                    Say("You didn't say anything!");
                }
                
                // Greeting responses
                else if (lowerInput.Contains("hello"))
                {
                    Say("Hello! How are you today?");
                }
                else if (lowerInput.Contains("hi"))
                {
                    Say("Hi there! Nice to meet you!");
                }
                
                // Questions about AI's state
                else if (lowerInput.Contains("how are you"))
                {
                    Say("I'm doing great, thank you for asking!");
                }
                
                // Questions about AI's identity
                else if (lowerInput.Contains("your name") || lowerInput.Contains("who are you"))
                {
                    Say("I'm TinyAI, a simple chatbot!");
                }
                
                // Time related questions
                else if (lowerInput.Contains("time"))
                {
                    Say($"Current time is {DateTime.Now:HH:mm}");
                }
                
                // Date related questions
                else if (lowerInput.Contains("date") || lowerInput.Contains("today"))
                {
                    Say($"Today is {DateTime.Now:dd/MM/yyyy}");
                }
                
                // Gratitude responses
                else if (lowerInput.Contains("thank"))
                {
                    Say("You're welcome!");
                }
                else if (lowerInput.Contains("huh") || lowerInput.Contains("hmm"))
                {
                    Say("hmm... What are you thinking for?");
                }
                // Goodbye messages
                else if (lowerInput.Contains("bye") || lowerInput.Contains("goodbye"))
                {
                    Say("Goodbye! Have a nice day!");
                }
                
                // Question about AI's capabilities
                else if (lowerInput.Contains("what can you do") || lowerInput.Contains("help"))
                {
                    Say("I can respond to greetings, tell time/date, and chat with you!");
                }
                
                // Default response for unrecognized input
                else
                {
                    Say("I'm still learning, but I heard you!");
                }
                
                Console.WriteLine();  // Add empty line for better readability
            }
        }
    }
}
