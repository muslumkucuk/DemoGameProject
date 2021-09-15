using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGameProject
{
    public class  UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1994 && gamer.FirstName == "Müslüm" && gamer.LastName == "Küçük" && gamer.IdentityNumber == 123456)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
