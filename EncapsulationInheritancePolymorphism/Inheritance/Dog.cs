using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism.Inheritance
{
    internal class Dog : Animal
    {
        public bool IsServiceDog { get; set; }

        public Dog(string name, double weight, int age, bool isServiceDog) : base(name, weight, age)
        {
            this.IsServiceDog = isServiceDog;
        }

        public override void DoSound()
        {
            Console.WriteLine("Bark bark! Woof Woof!");
        }

        public override string Stats()
        {
            //return $"Name: {Name}\nWeight: {Weight}\nAge: {Age}\nIs Service Dog: {IsServiceDog}";
            return base.Stats() + $"\nIs Service Dog: {IsServiceDog}";
        }

        public string Eat()
        {
            return "Nyam nyam";
        }
    }
}
