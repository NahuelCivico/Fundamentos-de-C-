using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_Programación
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1.ShowBigNumber();
            Exercise2.IsPair(10);
            Exercise3.MoreCharacters("Hi, how are you?", "I'm fine, and you?");
            Exercise4.GetHypotenuse(5, 5);
            Exercise5.PrintNumbers();
            Exercise6.ConvertCelsiusToFahrenheit(32.5);
            Exercise7.MultiplicationOfNumbers(new List<Int32>() { 3, 4, 5 });
            Exercise8.Factorial(6);
            Exercise9.Average(new List<Int32>() { 3, 4, 5 });
            Exercise10.GetBigNumber(new List<Int32>() { 3, 5, 4, 6, 7, 4, 10, 4 });
            Exercise11.GetAge(new DateTime(1992, 02, 06));
            Exercise12.FizzBuzz();
            Exercise13.ReverseList(new List<Int32>() { 4, 6, 49 });
            Exercise14.OrderList(new List<Int32>() { 5, 2, 9, 4 });
            Exercise15.OrderDescList(new List<Int32>() { 5, 2, 9, 4 });
            Exercise16.FirstCharacterOfList(new List<String>() { "Hola", "como", "andas?" });
            Exercise17.LastCharacterOfList(new List<String>() { "Hola", "como", "andas?" });
            Exercise18.isPalindro("ana");
        }
    }
}
