using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_Programación
{
    public class Exercise18
    {
        public static Boolean isPalindro(String word)
        {
            string str = string.Empty;
            int i = word.Length;
            for (int j = i - 1; j >= 0; j--)
            {
                str = str + word[j];
            }
            if (str == word)
                return true;
            else
                return false;
        }
    }
}
