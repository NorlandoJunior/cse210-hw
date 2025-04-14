using System;

namespace AnimalSoundSim
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
    }
}
