using System;

namespace team_activity
{
    public class PromptGenerator
    {
        private static readonly string[] _prompts =
        {
            "What was the best part of your day?",
            "What did you learn today?",
            "What made you smile today?",
            "What challenge did you overcome today?"
        };

        public static string GetRandomPrompt()
        {
            return _prompts[new Random().Next(_prompts.Length)];
        }
    }
}
