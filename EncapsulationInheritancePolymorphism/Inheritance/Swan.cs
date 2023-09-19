using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism.Inheritance
{
    internal class Swan : Bird
    {
        public string ForeverPartner { get; set; }

        public Swan(string name, double weight, int age, double wingSpan, string foreverPartner) : base(name, weight, age, wingSpan)
        {
            this.ForeverPartner = foreverPartner;
        }

        public override string Stats()
        {
            //return $"Name: {Name}\nWeight: {Weight}\nAge: {Age}\nWingspan: {WingSpan}\nForever Partner: {ForeverPartner}";
            return base.Stats() + $"\nForever Partner: {ForeverPartner}";
        }
    }
}
