using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_Programación
{
    public class Exercise11
    {
        public static Int32 GetAge(DateTime dateOfBirth)
        {
            return (DateTime.Today.Year - dateOfBirth.Year);
        }
    }
}
