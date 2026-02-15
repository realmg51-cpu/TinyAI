using System;
using System.Threading;

namespace TinyAI 
{
    class Program 
    {
        static void Main() 
        {
            // Support for Emojis in some consoles
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            
            // Welcome message with animation
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("✨ Welcome to TinyAI! Type 'exit' to say goodbye. ✨");
            Console.ResetColor();
            
            // Typing animation effect
            TypeWriter("Initializing AI system", 50);
            Console.WriteLine(" ✅");
            Thread.Sleep(500);
            
            bool isRunning = true;
            int conversationCount = 0;

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

                // Thinking animation for longer responses
                if (input.Length > 10)
                {
                    Console.Write("🤔");
                    Thread.Sleep(500);
                    Console.Write("\b \b"); // Erase the thinking emoji
                }

                // Using Modern Pattern Matching for cleaner code
                string response = input switch
                {
                    "" => "Don't be so quiet, talk to me! 😶",
                    "exit" => HandleExit(ref isRunning, conversationCount),
                    var s when s.Contains("hi") || s.Contains("hello") => "Hi there!! Nice to meet you! 👋",
                    var s when s.Contains("hey") => "Yo! What's up? How can I help you? 😎",
                    var s when s.Contains("hmm") => "Hmm... Thinking hard? Need me to think for you? 🤔",
                    var s when s.Contains("stupid") => "I'm not stupid, I'm just saving my energy! 🧠",
                    var s when s.Contains("lunar new year") => GetLunarNewYearResponse(),
                    var s when s.Contains("how are you") => GetMoodResponse(conversationCount),
                    var s when s.Contains("weather") => "I can't check weather yet, but I hope it's sunny where you are! ☀️",
                    var s when s.Contains("joke") => GetRandomJoke(),
                    var s when s.Contains("love") => "Aww, I love you too! ❤️ (in a friendly AI way, of course!)",
                    var s when s.Contains("thank") => "You're welcome! That's what I'm here for! 😊",
                    var s when s.Contains("help") => GetHelpMessage(),
                    var s when s.Contains("who are you") => "I'm TinyAI, your friendly neighborhood chatbot! 🤖",
                    _ => "Too hard for me... I haven't learned that part yet! 😅",
                };

                Console.WriteLine(response);
                conversationCount++;
            }
        }

        static string HandleExit(ref bool isRunning, int conversationCount)
        {
            isRunning = false;
            
            if (conversationCount > 5)
            {
                return $"Goodbye! We had {conversationCount} nice conversations! I'm going to take a nap now~ 😴";
            }
            return "Goodbye! I'm going to take a nap now~ 😴";
        }

        static string GetLunarNewYearResponse()
        {
            string[] responses = {
                "Happy Lunar New Year! 🧧 May the Year of the Dragon bring you prosperity! 🐉",
                "Chúc mừng năm mới! Happy Lunar New Year to our Vietnamese friends! 🎋",
                "恭喜发财! Wishing you good fortune in the Lunar New Year! 🧨",
                "Tết đến rồi! Chúc bạn năm mới an khang thịnh vượng! 🎊"
            };
            
            Random rand = new Random();
            return responses[rand.Next(responses.Length)];
        }

        static string GetMoodResponse(int conversationCount)
        {
            if (conversationCount < 3)
                return "I'm doing great! Thanks for asking! 🤗";
            else if (conversationCount < 10)
                return "Still energized and ready to chat! ⚡";
            else
                return "A bit tired but happy to keep talking with you! 💫";
        }

        static string GetRandomJoke()
        {
            string[] jokes = {
                "Why don't scientists trust atoms? Because they make up everything! 😄",
                "What do you call a fake noodle? An impasta! 🍝",
                "Why did the scarecrow win an award? Because he was outstanding in his field! 🌾",
                "What do you call a bear with no teeth? A gummy bear! 🐻",
                "Why don't eggs tell jokes? They'd crack each other up! 🥚"
            };
            
            Random rand = new Random();
            return jokes[rand.Next(jokes.Length)];
        }

        static string GetHelpMessage()
        {
            return @"I can respond to:
• Greetings (hi, hello, hey)
• Questions about Lunar New Year/Tết
• Jokes (just say 'joke')
• How I'm feeling
• And more! Try asking me things! 🎯";
        }

        static void TypeWriter(string message, int delay)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }
    }
}