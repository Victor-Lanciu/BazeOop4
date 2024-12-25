using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public interface Irunnable
    {
        void Run();
    }
    public abstract class Animal
    {
        public abstract void MakeSound();
        public virtual void Eat()
        {
            Console.WriteLine("Animalul mananca");
        }

    }
    public class Dog : Animal, Irunnable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cainele latra");
        }
        public override void Eat()
        {
            Console.WriteLine("Cainele mananca oase");
        }
        public void Run()
        {
            Console.WriteLine("Dog runs");
        }
    }
    public class Cat : Animal, Irunnable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Pisica miauna");
        }
        public override void Eat()
        {
            Console.WriteLine("Pisica mananca peste");
        }
        public void Run()
        {
            Console.WriteLine("Cat runs");
        }
    }
}
