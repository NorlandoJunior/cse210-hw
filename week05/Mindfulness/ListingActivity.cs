using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ListingActivity : MindfulnessActivity
    {
        private static readonly string[] _prompts =
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by prompting you to list items.") { }

        protected override void RunActivity()
        {
            Random rand = new Random();
            Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Length)]);
            PauseWithAnimation(3);
            List<string> responses = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("Enter a response: ");
                responses.Add(Console.ReadLine());
            }
            Console.WriteLine($"\nYou listed {responses.Count} items.");
        }
    }
}