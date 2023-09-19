using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism.Inheritance
{
    internal class Bird : Animal
    {
        public double WingSpan { get; set; }
        public Bird(string name, double weight, int age, double wingSpan) : base(name, weight, age)
        {
            this.WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            
            Console.WriteLine("Chirp chirp...");
        }

        public override string Stats()
        {
            //return $"Name: {Name}\nWeight: {Weight}\nAge: {Age}\nWingspan: {WingSpan}";
            return base.Stats() + $"\nWingspan: { WingSpan} cm";
        }
    }
}
