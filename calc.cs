using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[1000000];
            int[] array2 = new int[1000000];

            DateTime inicio, fim;
            inicio = DateTime.Now;
            for (int j = 0; j < 1000; ++j)
            {
                for (int i = 0; i < 1000000; i++)
                {
                    array2[i] = i;
                    array1[i] = array2[i];
                }
            }

            

            fim = DateTime.Now;

            Console.WriteLine("Inicio em....: " + inicio);
            Console.WriteLine("Fim em.......: " + fim);
            Console.WriteLine("Tempo Total..: " + (fim - inicio) + "ms.");
            Console.ReadKey();

        }
    }
}
