using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism.Inheritance
{
    abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public abstract void DoSound();

        public Animal(string name, double weight, int age)
        {
            this.Name = name;
            this.Weight = weight;   
            this.Age = age;
        }

        public virtual string Stats()
        {
            return $"Name: {Name}\nWeight: {Weight} kg\nAge: {Age} years";
        }
    }
}
