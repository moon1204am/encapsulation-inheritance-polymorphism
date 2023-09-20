using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism.Inheritance
{
    internal class Flamingo : Bird
    {
        public bool IsPink { get; set; }

        public Flamingo(string name, double weight, int age, double wingSpan, bool isPink) : base(name, weight, age, wingSpan)
        {
            this.IsPink = isPink;
        }

        public override string Stats()
        {
            return base.Stats() + $"\nIs Pink: {IsPink}";
        }
    }
}
