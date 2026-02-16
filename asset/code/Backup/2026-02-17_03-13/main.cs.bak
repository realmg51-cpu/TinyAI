using System;
using System.Threading;
using System.Data; // Cần thiết để tính toán chuỗi toán học

namespace TinyAI
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("✨ Welcome to TinyAI v1.4.0! Type 'exit' to say goodbye. ✨");
            Console.ResetColor();

            TypeWriter("Initializing AI system", 40);
            Console.WriteLine(" ✅");

            // --- TÍNH NĂNG MỚI: LƯU TÊN USER ---
            Console.Write("AI: Before we start, what's your name? 😊 ");
            string userName = Console.ReadLine()?.Trim() ?? "Friend";
            if (string.IsNullOrEmpty(userName)) userName = "Friend";
            
            Console.WriteLine($"AI: Nice to meet you, {userName}! How can I help you today? ✨");
            // ----------------------------------

            bool isRunning = true;
            int conversationCount = 0;

            while (isRunning)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"\n{userName}: ");
                Console.ResetColor();

                string input = Console.ReadLine()?.ToLower().Trim() ?? "";

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("AI: ");
                Console.ResetColor();

                if (input.Length > 10)
                {
                    Console.Write("🤔");
                    Thread.Sleep(500);
                    Console.Write("\b \b");
                }

                // Logic xử lý phản hồi
                string response = input switch
                {
                    "" => "Don't be so quiet, talk to me! 😶",
                    "exit" => HandleExit(ref isRunning, conversationCount, userName),
                    var s when s.Contains("hi") || s.Contains("hello") => $"Hi {userName}!! Nice to meet you! 👋",
                    var s when s.Contains("hey") => $"Yo {userName}! What's up? How can I help? 😎",
                    
                    // --- TÍNH NĂNG MỚI: TÍNH TOÁN ---
                    var s when IsMathExpression(s) => Calculate(s),
                    
                    var s when s.Contains("lunar new year") || s.Contains("tết") => GetLunarNewYearResponse(),
                    var s when s.Contains("how are you") => GetMoodResponse(conversationCount, userName),
                    var s when s.Contains("weather") => "I can't check weather yet, but I hope it's sunny! ☀️",
                    var s when s.Contains("joke") => GetRandomJoke(),
                    var s when s.Contains("thank") => $"You're welcome, {userName}! Anytime! 😊",
                    var s when s.Contains("help") => GetHelpMessage(),
                    var s when s.Contains("who are you") => "I'm TinyAI, your friendly neighborhood chatbot! 🤖",
                    _ => $"Hmm, '{input}' is a bit hard for me... I'm still learning! 😅",
                };

                Console.WriteLine(response);
                conversationCount++;
            }
        }

        // Kiểm tra xem input có phải là phép tính không (đơn giản)
        static bool IsMathExpression(string input)
        {
            // Kiểm tra xem chuỗi có chứa số và các dấu toán học cơ bản không
            return System.Text.RegularExpressions.Regex.IsMatch(input, @"^[0-9\+\-\*\/\.\s\(\)]+$") 
                   && System.Text.RegularExpressions.Regex.IsMatch(input, @"[0-9]");
        }

        // Thực hiện tính toán
        static string Calculate(string expression)
        {
            try
            {
                // Sử dụng DataTable để tính toán chuỗi toán học nhanh gọn
                var table = new DataTable();
                var result = table.Compute(expression, string.Empty);
                return $"The result of '{expression}' is: {result} 🧮";
            }
            catch
            {
                return "I tried to calculate that, but the numbers got tangled! 😵‍💫";
            }
        }

        static string HandleExit(ref bool isRunning, int conversationCount, string name)
        {
            isRunning = false;
            return conversationCount > 5 
                ? $"Goodbye {name}! We had {conversationCount} great chats! Zzz... 😴" 
                : $"Bye {name}! See you later! 😴";
        }

        static string GetLunarNewYearResponse()
        {
            string[] responses = {
                "Happy Lunar New Year! 🧧 May the Dragon bring you luck! 🐉",
                "Chúc mừng năm mới! An khang thịnh vượng! 🎋",
                "Tết đến rồi! Chúc bạn nhận được nhiều lì xì nhé! 🧧"
            };
            return responses[new Random().Next(responses.Length)];
        }

        static string GetMoodResponse(int count, string name)
        {
            if (count < 3) return $"I'm feeling awesome, {name}! Thanks for asking! 🤗";
            return $"A bit busy thinking, but always happy to chat with you, {name}! ⚡";
        }

        static string GetRandomJoke()
        {
            string[] jokes = {
                "Why don't scientists trust atoms? Because they make up everything! 😄",
                "What do you call a fake noodle? An impasta! 🍝",
                "What do you call a bear with no teeth? A gummy bear! 🐻"
            };
            return jokes[new Random().Next(jokes.Length)];
        }

        static string GetHelpMessage()
        {
            return "I can help with:\n" +
                   "• Math: Just type something like '5 * 5 + 10'\n" +
                   "• Fun: Jokes, Tết greetings, How are you\n" +
                   "• Basics: Hello, Who are you, Help\n" +
                   "• Exit: Type 'exit' to quit. 🎯";
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
