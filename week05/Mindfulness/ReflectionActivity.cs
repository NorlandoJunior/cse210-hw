using System;

namespace Mindfulness
{
    public class ReflectionActivity : MindfulnessActivity
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
}
