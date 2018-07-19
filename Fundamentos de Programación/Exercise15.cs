using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_Programación
{
    public class Exercise15
    {
        public static List<Int32> OrderDescList(List<Int32> numbers)
        {
            return numbers.OrderByDescending(x => x).ToList();
        }
    }
}
