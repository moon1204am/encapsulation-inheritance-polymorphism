using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism.Inheritance
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, string pack) : base(name, weight, age, pack)
        {
        }

        public void Talk()
        {
            Console.WriteLine("Hej, Aooooo!");
        }

        public override string Stats()
        {
            return $"Name: {Name}\nWeight: {Weight}\nAge: {Age}";
        }
    }
}
