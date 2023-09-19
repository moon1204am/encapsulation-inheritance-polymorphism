using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism.Polymorphism
{
    internal class AgeInputError : UserError
    {
        public override string UEMessage()
        {
            return "You entered an age below 18. You need to be at least 18 years old.";
        }
    }
}
