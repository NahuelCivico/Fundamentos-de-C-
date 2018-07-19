using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_Programación
{
    public class Exercise8
    {
        public static Int64 Factorial(Int64 a)
        {
            var result = 1;
            for (int i = 1; i <= a; i++)
            {
                result *= i;
            }
            return result;
        }

        public static Int64 Fact(Int64 a)
        {
            if (a == 2) return a;
            return a * Fact(a - 1);
        }
    }
}
