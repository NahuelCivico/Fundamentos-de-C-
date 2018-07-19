using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_Programación
{
    public class Exercise12
    {
        public static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
            Console.ReadKey();
        }

        //For JavaScript
        //function alertFizzBuzz(numrange)
        //{
        //    var result = [];
        //    for (var i = 1; i <= numrange; i++)
        //    {
        //        result.push(fizzOrBuzz(i));
        //    }
        //    alert(result.join(','));
        //}
        //function fizzOrBuzz(num)
        //{
        //    if (num % 3 === 0)
        //    {
        //        if (num % 5 === 0)
        //        {
        //            return 'FizzBuzz';
        //        }
        //        return 'Fizz';
        //    }
        //    if (num % 5 === 0)
        //    {
        //        return 'Buzz';
        //    }
        //    return num;
        //}
        //alertFizzBuzz(100);
    }
}
