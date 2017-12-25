using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string res;

            for (int i = 1; i <= 100; i++)
            {
                res = "";

                res += (i % 3 == 0 ? "Fizz" : "");
                
                res += (i % 5 == 0 ? "Buzz" : "");

                res += (String.IsNullOrWhiteSpace(res) ? i.ToString() : "");

                Console.Write(res + "\t");
            }
            Console.ReadLine();
        }
    }
}
