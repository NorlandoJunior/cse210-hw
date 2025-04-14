using System;

namespace AnimalSoundSim
{
    public class Bird : Animal
    {
        public Bird(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Tweet!");
        }
    }
}
