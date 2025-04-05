using System;
using System.Collections.Generic;
using System.Threading;

namespace Mindfulness
{
    public abstract class MindfulnessActivity
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
            List<string> animationStrings = new List<string>() { "|", "/", "-", "\\" };
            int animationIndex = 0;

            DateTime endTime = DateTime.Now.AddSeconds(seconds);

            while (DateTime.Now < endTime)
            {
                Console.Write(animationStrings[animationIndex]);
                Thread.Sleep(250);
                Console.Write("\b");

                animationIndex = (animationIndex + 1) % animationStrings.Count;
            }
        }

        protected abstract void RunActivity();
    }
}
