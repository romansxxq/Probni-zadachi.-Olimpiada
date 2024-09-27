using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пробні_задачі.Олімпіада
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);

            int sum = a + b;

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
