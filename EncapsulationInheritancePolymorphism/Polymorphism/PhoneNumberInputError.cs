using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism.Polymorphism
{
    internal class PhoneNumberInputError : UserError
    {
        public override string UEMessage()
        {
            return "The phone number did not start with + sign at the beginning. This caused an error!";
        }
    }
}
