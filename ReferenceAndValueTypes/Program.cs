using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);

            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" }; //101
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };//102 
            cities2 = cities1;//cities2 = 102 -> 101
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]);


           
            Console.ReadLine();
        }
    }
}
