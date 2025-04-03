using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    abstract class MindfulnessActivity
    {
        protected int duration;

        public void Start()
        {
            Console.Clear();
            DisplayStartingMessage();
            PauseWithAnimation(3);
            RunActivity();
            DisplayEndingMessage();
        }

        protected void DisplayStartingMessage()
        {
            Console.WriteLine($"Starting {this.GetType().Name}...");
            Console.Write("Enter duration in seconds: ");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Get ready...");
            PauseWithAnimation(3);
        }

        protected void DisplayEndingMessage()
        {
            Console.WriteLine("Great job! You've completed the activity.");
            Console.WriteLine($"You spent {duration} seconds in {this.GetType().Name}.");
            PauseWithAnimation(3);
        }

        protected void PauseWithAnimation(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        protected abstract void RunActivity();
    }

    class BreathingActivity : MindfulnessActivity
    {
        protected override void RunActivity()
        {
            DateTime endTime = DateTime.Now.AddSeconds(duration);
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...");
                PauseWithAnimation(3);
                Console.WriteLine("Breathe out...");
                PauseWithAnimation(3);
            }
        }
    }

    class ReflectionActivity : MindfulnessActivity
    {
        private static readonly string[] prompts =
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        protected override void RunActivity()
        {
            Random rand = new Random();
            Console.WriteLine(prompts[rand.Next(prompts.Length)]);
            PauseWithAnimation(3);
            DateTime endTime = DateTime.Now.AddSeconds(duration);
            while (DateTime.Now < endTime)
            {
                Console.Write("Reflecting...");
                PauseWithAnimation(3);
            }
        }
    }

    class ListingActivity : MindfulnessActivity
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

    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness App");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                MindfulnessActivity activity = choice switch
                {
                    "1" => new BreathingActivity(),
                    "2" => new ReflectionActivity(),
                    "3" => new ListingActivity(),
                    _ => null
                };
                if (choice == "4") break;
                activity?.Start();
            }
        }
    }
}

