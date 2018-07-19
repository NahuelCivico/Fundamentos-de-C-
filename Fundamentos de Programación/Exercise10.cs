using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_Programación
{
    public class Exercise10
    {
        public static Int32 GetBigNumber(List<Int32> numbers)
        {
            var result = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (result < numbers[i])
                {
                    result = numbers[i];
                }
            }

            return result;
        }
    }
}
