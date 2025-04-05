using System;

namespace Mindfulness
{
    public class ReflectionActivity : MindfulnessActivity
    {
        private static readonly string[] _prompts =
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.") { }

        protected override void RunActivity()
        {
            Random rand = new Random();
            Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Length)]);
            PauseWithAnimation(3);
            DateTime endTime = DateTime.Now.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("Reflecting...");
                PauseWithAnimation(3);
            }
        }
    }
}