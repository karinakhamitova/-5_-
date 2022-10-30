using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_3_Хамитова
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int[] array = new int[n];
            int i = 0;
            int k = 0;
            Random r = new Random();
            for (i = 0; i < n; i++)
            {
                array[i] = r.Next(-50, 50);
                Console.Write("{0} ", array[i]);
                if ((i % 2 == 1) && (array[i] >= 0) && (array[i] % 2 == 1))///не совсем поняла, относительно чего четное место, индекса или позиции, поэтому оставила так 
                {
                    k++;
                }                                                       
            }
            Console.WriteLine();
            Console.WriteLine("Количество  нечетных положительных элементов, стоящих на четных местах - {0}",k);
            Console.ReadKey();
        }
    }
}
