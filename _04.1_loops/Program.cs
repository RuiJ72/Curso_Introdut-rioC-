using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._1_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Com DO While, resultando no mesmo efeito mas faz a operação primeiro e depois vai para a condição

            //int a = 1;
            //do
            //{
            //    if (a == 4) // Experimentar com outros numeros
            //    {
            //        break;
            //    }
            //    Console.WriteLine(a);
            //    a++;
            //    Console.ReadKey();
            //}

            //while (a <= 10);

            //Com o FOR

            { 

                for (int a = 1; a <= 10; a++)
                {
                    Console.WriteLine(a); // O mesmo resultado dos anteriores, mas a válvula de escape está dentro do FOR
                }
            }
            Console.ReadLine();
            
        }
    }
}
