using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_Programación
{
    public class Exercise7
    {
        public static Int32 MultiplicationOfNumbers(List<Int32> numbers)
        {
            var result = 1;
            foreach (var number in numbers)
            {
                result *= number;
            }
 
            return result;
        }
    }
}
