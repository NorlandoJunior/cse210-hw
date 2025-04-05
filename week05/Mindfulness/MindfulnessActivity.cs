using System;
using System.Collections.Generic;
using System.Threading;

namespace Mindfulness
{
    public abstract class MindfulnessActivity
    {
        protected int _duration;
        protected string _name;
        protected string _description;

        public MindfulnessActivity(string name, string description)
        {
            _name = name;
            _description = description;
        }

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
            Console.WriteLine($"Starting {_name}...");
            Console.WriteLine(_description);
            Console.Write("Enter duration in seconds: ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Get ready...");
            PauseWithAnimation(3);
        }

        protected void DisplayEndingMessage()
        {
            Console.WriteLine("\nGreat job! You've completed the activity.");
            Console.WriteLine($"You spent {_duration} seconds in {_name}.");
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

            Console.WriteLine();
        }

        protected abstract void RunActivity();
    }
} 