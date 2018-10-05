using FizzBuzz.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto TDD Fizz Buzz");

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzzer.GetValue(i));
            }

            Console.ReadKey();
        }
    }
}
