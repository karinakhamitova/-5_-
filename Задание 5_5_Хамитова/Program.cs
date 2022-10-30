using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_5_Хамитова
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n,n];
            int i,j = 0;
            Console.WriteLine("Vvedite massiv iz 7 elementov:");

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    if ((i % 2 == 0) && (j % 2 == 0))
                    {
                        array[i, j] = 1;
                        Console.Write("{0} ", array[i, j]);
                    }
                    else if ((i % 2 == 1) && (j % 2 == 1))
                    {
                        array[i, j] = 1;
                        Console.Write("{0} ", array[i, j]);
                    }

                    else
                    {
                        array[i, j] = 0;
                        Console.Write("{0} ", array[i, j]);
                    }
                

                Console.WriteLine();
            }
            Console.ReadKey();
      
            
        }
    }
}