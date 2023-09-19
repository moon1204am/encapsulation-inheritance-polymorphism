using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism.Polymorphism
{
    internal class EmailAddressInputError : UserError
    {
        public override string UEMessage()
        {
            return "The email address is missing an @ sign in between of the username and domain name. This caused an error!";
        }
    }
}
