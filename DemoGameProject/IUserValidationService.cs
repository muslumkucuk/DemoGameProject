using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGameProject
{
    public interface IUserValidationService
    {
        public bool Validate(Gamer gamer);
    }
}
