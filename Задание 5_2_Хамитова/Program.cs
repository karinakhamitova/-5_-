using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_2_Хамитова
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] array = new int[n];
            int i = 0;
            Random r= new Random();
            for (i = 0; i < n; i++)
            {
                array[i] = r.Next(0,50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Array.Sort(array);
            Console.WriteLine("Summa max+min={0}", array[0] + array[n-1]);
            Console.ReadKey();
        }
    }
}
