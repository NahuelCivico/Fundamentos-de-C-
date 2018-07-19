using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_Programación
{
    public class Exercise5
    {
        public static void PrintNumbers()
        {
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
