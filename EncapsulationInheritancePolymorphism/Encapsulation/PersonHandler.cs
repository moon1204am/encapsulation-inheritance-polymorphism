using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism.Encapsulation
{
    public class PersonHandler
    {
        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person person = new Person();
            person.Age = age;
            person.FName = fName;
            person.LName = lName;
            person.Height = height;
            person.Weight = weight;

            return person;
        }

        public int GetAge(Person pers)
        {
            return pers.Age;
        }

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public string GetFName(Person pers)
        {
            return pers.FName;
        }

        public void SetFName(Person pers, string fName)
        {
            pers.FName = fName;
        }

        public string GetLName(Person pers)
        {
            return pers.LName;
        }

        public void SetLName(Person pers, string lName)
        {
            pers.LName = lName;
        }

        public double GetHeight(Person pers)
        {
            return pers.Height;
        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public double GetWeight(Person pers)
        {
            return pers.Weight;
        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
    }
}
