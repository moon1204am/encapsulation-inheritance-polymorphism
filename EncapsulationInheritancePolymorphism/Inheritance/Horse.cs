using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism.Inheritance
{
    internal class Horse : Animal
    {
        public double HighestJump { get; set; }

        public Horse(string name, double weight, int age, double highestJump) : base(name, weight, age)
        {
            this.HighestJump = highestJump;
        }

        public override void DoSound()
        {
            Console.WriteLine("Neeeeigh!");
        }

        public override string Stats()
        {
            return base.Stats() + $"\nHighest jump: {HighestJump}";
        }
    }
}
