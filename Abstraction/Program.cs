using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer programmer = new Programmer();
            programmer.Age = 1;
            programmer.Name = "Marc";
            programmer.Introduce();
            programmer.Live();
            programmer.DoJob();

            Console.ReadLine();
        }
    }

    public class Programmer : Person
    {
        public override void DoJob()
        {
            Console.WriteLine("Create Softwares");
        }

        public override void Live()
        {
            base.Live();
            Console.WriteLine("Eat");
        }
    }

    public abstract class Person : ILivingCreature, INamedPerson
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hi! I'm {Name} and I am {Age} year/s old");
        }

        public virtual void Live()
        {
            Console.WriteLine("Breath");
        }

        public abstract void DoJob();
    }

    public interface ILivingCreature
    {
        int Age { get; set; }
        void Live();
    }

    public interface INamedPerson
    {
        string Name { get; set; }
        void Introduce();
    }
}
