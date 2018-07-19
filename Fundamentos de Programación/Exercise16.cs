using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_Programación
{
    public class Exercise16
    {
        public static void FirstCharacterOfList(List<String> strings)
        {
            for (int i = 0; i < strings.Count; i++)
            {
                Console.WriteLine(strings[i].First());
            }

            Console.ReadKey();
        } 
    }
}
