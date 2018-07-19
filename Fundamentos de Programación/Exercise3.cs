using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_Programación
{
    public class Exercise3
    {
        public static String MoreCharacters(String stringOne, String stringTwo)
        {
            if (stringOne.Length > stringTwo.Length)
            {
                return stringOne;
            }
            else if (stringOne.Length == stringTwo.Length)
            {
                return stringOne;
            }
            else
            {
                return stringTwo;
            }
        }
    }
}
