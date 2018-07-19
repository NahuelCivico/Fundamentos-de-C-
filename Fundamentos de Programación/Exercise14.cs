using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_Programación
{
    public class Exercise14
    {
        public static List<Int32> OrderList(List<Int32> numbers)
        {
            return numbers.OrderBy(x => x).ToList();
        }
    }
}
