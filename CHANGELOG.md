## 1.0.0:

   - First  version of TinyAI.

##  1.1.0:

## ✨ New Features

  - More intelligent.
  - At `Console.ReadLine()`,Add `ToLower()` and `Trim()` to understand lowercase and remove unwanted space.

## 1.2.0: 

## ✨ New Features
   - Rewrite code.

   - Colors: Added Console.ForegroundColor to distinguish between You and the AI.

   - Switch Expressions: Removed the long chain of else if, making the code look professional.

- Emojis: Tossed in some personality to keep it fun! 🐧

## 1.2.1:

- Fix syntax errors. I'm sorry...

  ## 1.3.0:
  
## ✨ New Features

- Typing Animation: Added typewriter effect during system initialization for a more dynamic startup experience
- Thinking Animation: AI now shows a "🤔" emoji when processing longer questions (>10 characters)
- Conversation Counter: Tracks number of exchanges to provide context-aware responses
- Smart Exit Messages: Goodbye message now shows total conversation count if you've chatted more than 5 times

🎯 Enhanced Responses

- Lunar New Year: Multiple random messages for Vietnamese and Chinese New Year celebrations
- Mood System: AI's mood changes based on conversation length (energetic → friendly → tired)
- Joke Generator: Random joke collection with emojis (just say "joke")
**- New Topics Added:**
  - Weather inquiries
  - Love/friendly responses
  - Thank you acknowledgments
  - Help menu with available commands
  - Identity questions ("who are you")

🎨 Visual Improvements

- Colored console output for better readability
- Emoji support enhanced with more context-appropriate icons
- Cleaner response formatting with loading indicators

**🛠️ Technical Improvements**

- Better code organization with helper methods
- Randomized responses for repeated queries
- Threading for smooth animations
- Extended pattern matching cases

**1.3.1:**

  - A few minor tweaks to optimize the code.
  
   ## 1.4.0:

  ## User Identity Management:

- Added an initialization sequence to ask for the user's name at startup. 👤

- Integrated personalized responses across all dialogue modules (Greetings, Mood, Exit).

- Improved the AI's "memory" by using the stored userName throughout the session.

- Integrated Math Engine:

- Implemented an automated Math Detection system using Regex (Regular Expressions). 🧮

- Added support for basic and complex arithmetic expressions (e.g., (10 + 5) * 2).

- Powered by System.Data for high-accuracy string-to-math evaluation.

- Included error handling for "tangled" (invalid) mathematical expressions. 😵‍💫

##Improvements & Tweaks
- Dynamic UI: The console prompt now displays your name instead of a generic "You" (e.g., John: ).

- Optimized Typewriter Effect: Adjusted the delay for a smoother "human-like" typing feel. ⌨️

- Enhanced Logic: Refined the switch expression to prioritize math calculations before falling back to default responses.

## Bug Fixes
- Fixed a bug where empty inputs would sometimes trigger a generic error.

- Added better null-check handling for user inputs to prevent crashes.
