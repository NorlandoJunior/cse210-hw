using System;

namespace Mindfulness
{
    public class BreathingActivity : MindfulnessActivity
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
}
