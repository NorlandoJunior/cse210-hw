using System;

namespace Mindfulness
{
    public class BreathingActivity : MindfulnessActivity
    {
        public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through breathing in and out slowly.") { }

        protected override void RunActivity()
        {
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("\nBreathe in...");
                PauseWithAnimation(3);
                Console.WriteLine("Breathe out...");
                PauseWithAnimation(3);
            }
        }
    }
}