using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog("Doggie");
            Bird bird = new Bird("Birdie");
            GetTypeAndTestSound(dog);
            GetTypeAndTestSound(bird);
            dog.Breath();
            dog.Walk();
            bird.Breath();
            Console.ReadKey();
        }

        public static void GetTypeAndTestSound(IAnimal animal)
        {
            Console.Write($"Animal Name: {animal.Name}; Animal Type: {animal.Type}; Animal Sound: ");
            animal.MakeSound();
        }
    }
}
