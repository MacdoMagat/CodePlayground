using System;

namespace InterfaceSample
{
    public class Dog : IAnimal, ILandAnimal
    {
        public AnimalType Type { get; }
        public string Name { get; private set; }
        
        public Dog(string name)
        {
            Type = AnimalType.Mammal;
            Name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine("Arf! Arf!");
        }

        public void Breath()
        {
            Console.WriteLine("I'm breathing.");
        }

        public void Walk()
        {
            Console.WriteLine("I'm walking.");
        }
    }
}
