using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_1_Хамитова
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            int[] array=new int[n];
            int i = 0;
            double s=0;
            Console.WriteLine("Vvedite massiv iz 7 elementov:");
            for (i = 0; i <n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                s += array[i];
            }
            Console.WriteLine("Srednee arefmeticheskoe ravno - {0:f2}",s/n);
            Console.ReadKey();
        }
    }
}


