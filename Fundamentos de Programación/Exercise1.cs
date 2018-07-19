using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_Programación
{
    public class Exercise1
    {
        public static void ShowBigNumber()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Ingrese un numero");
                    Int32 numberOne = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese otro numero");
                    Int32 numberTwo = Int32.Parse(Console.ReadLine());

                    if (numberOne > numberTwo)
                    {
                        Console.WriteLine("The big number is: " + numberOne);
                    }
                    else if (numberOne == numberTwo)
                    {
                        Console.WriteLine("The numbers are the same: " + numberOne + ", " + numberTwo);
                    }
                    else
                    {
                        Console.WriteLine("The big number is: " + numberTwo);
                    }

                    Console.ReadKey();

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ingresá solo números");
                }     
            }             
        }
    }
}
