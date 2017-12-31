using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfMultiplesOf3And5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            Console.WriteLine(DateTime.Now.ToLongTimeString());

            for (int i = 3; i < number ; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(DateTime.Now.ToLongTimeString());

            Console.WriteLine("sum of Multiples : {0}", sum);
        }
    }
}
