using System;

namespace InterfaceSample
{
    public class Bird : IAnimal
    {
        public AnimalType Type { get; }
        public string Name { get; private set; }

        public Bird(string name)
        {
            Type = AnimalType.Bird;
            Name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine("Tweet! Tweet!");
        }

        public void Breath()
        {
            Console.WriteLine("I'm breathing.");
        }
    }
}
