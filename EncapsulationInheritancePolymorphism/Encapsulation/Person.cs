using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism.Encapsulation
{
    public class Person
    {
        private int age;
        public int Age
        {
            get
            { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Not a valid age. Must be over 0.");
                }
                age = value;
            }
        }

        private string fName;
        public string FName
        {
            get { return fName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("Not a valid first name. Must be at least 2 letters long and at most 10 letters.");
                }

                fName = value;
            }
        }

        private string lName;
        public string LName
        {
            get { return lName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Not a valid last name. Must be at least 3 letters long and at most 15 letters.");
                }
                lName = value;
            }
        }

        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }



    }
}
