using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism.Inheritance
{
    internal class Worm : Animal
    {
        public bool IsPoisonous { get; set; }

        public Worm(string name, double weight, int age, bool isPoisonous) : base(name, weight, age)
        {
            this.IsPoisonous = isPoisonous;
        }

        public override void DoSound()
        {
            Console.WriteLine("Pop pop!!!");
        }

        public override string Stats()
        {
            return base.Stats() + $"\nIs poisonous: {IsPoisonous}";
        }
    }
}
