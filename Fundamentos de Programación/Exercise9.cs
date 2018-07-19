using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_Programación
{
    public class Exercise9
    {
        public static Int32 Average(List<Int32> numbers)
        {
            Int32 result = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                result += numbers[i];
            }

            return result / numbers.Count;
        }
    }
}
