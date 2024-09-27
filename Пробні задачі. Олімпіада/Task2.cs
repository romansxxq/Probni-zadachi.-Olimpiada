using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пробні_задачі.Олімпіада
{
    class Task2
    {
        static int NZP(int[] args)
        {
            int n = args.Length;
            int[] nzp = new int[n];

            for (int i = 0; i < n; i++) 
                nzp[i] = 1;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < i; j++)
                    if (args[i] > args[j] && nzp[i] < nzp[j] + 1)
                        nzp[i] = nzp[j] + 1;

            return nzp.Max();

        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] args = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int res = NZP(args);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
