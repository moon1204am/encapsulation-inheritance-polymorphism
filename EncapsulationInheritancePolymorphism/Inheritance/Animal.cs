using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism.Inheritance
{
    /// <summary>
    /// Abstract class representing an animal, with two methods, 
    /// one to be imlpemented by derived classes, and one that prints its stats.
    /// </summary>
    abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public Animal(string name, double weight, int age)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
        }

        public abstract void DoSound();
        public virtual string Stats()
        {
            return $"Name: {Name}\nWeight: {Weight} kg\nAge: {Age} years";
        }
    }
}
