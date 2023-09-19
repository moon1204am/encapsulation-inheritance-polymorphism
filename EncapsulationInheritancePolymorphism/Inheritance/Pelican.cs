using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism.Inheritance
{
    internal class Pelican : Bird
    {
        public int NrOfFishInMouth { get; set; }

        public Pelican(string name, double weight, int age, double wingSpan, int nrOfFishInMouth) : base(name, weight, age, wingSpan)
        {
            this.NrOfFishInMouth = nrOfFishInMouth;
        }

        public override string Stats()
        {
            //return $"Name: {Name}\nWeight: {Weight}\nAge: {Age}\nWingspan: {WingSpan}\nFishes in mouth: {FishesInMouth}";
            return base.Stats() + $"\nFishes in mouth: {NrOfFishInMouth}";
        }
    }
}
