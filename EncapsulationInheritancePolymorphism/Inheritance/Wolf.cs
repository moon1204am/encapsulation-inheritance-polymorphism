using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism.Inheritance
{
    internal class Wolf : Animal
    {
        public string Pack { get; set; }

        public Wolf(string name, double weight, int age, string pack) : base(name, weight, age)
        {
            this.Pack = pack;
        }

        public override void DoSound()
        {
            Console.WriteLine("Aooooooo!");
        }

        public override string Stats()
        {
            //return $"Name: {Name}\nWeight: {Weight}\nAge: {Age}\nPack: {Pack}";
            return base.Stats() + $"\nPack: {Pack}";
        }
    }
}
