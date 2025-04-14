using System;
using System.Collections.Generic;

namespace AnimalSoundSim
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Dog("Rex"),
                new Cat("Whiskers"),
                new Bird("Tweety")
            };

            Console.WriteLine("Animal Sounds:\n");

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}
