namespace AnimalSoundSim
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound...");
        }
    }
}
