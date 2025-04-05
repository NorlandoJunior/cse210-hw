using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ListingActivity : MindfulnessActivity
    {
        private static readonly string[] prompts =
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "Who are some of your personal heroes?"
        };

        protected override void RunActivity()
        {
            Random rand = new Random();
            Console.WriteLine(prompts[rand.Next(prompts.Length)]);
            PauseWithAnimation(3);

            List<string> responses = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(duration);
            while (DateTime.Now < endTime)
            {
                Console.Write("Enter a response: ");
                responses.Add(Console.ReadLine());
            }

            Console.WriteLine($"You listed {responses.Count} items.");
        }
    }
}
