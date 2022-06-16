using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// While
            //int a = 1;
            //while (a <= 10)
            //{
            //    if (a == 1) 
            //    {
            //        a++;
            //        continue;

            //    }
            //    Console.WriteLine(a);
            //    a++;

            //}
            //Console.ReadKey();

            //Com Break
            int a = 1;
            while(a<= 10)
            {
                if(a == 4) // Vai do um até ao 4 quando chega ao 4, sai da operação e não mostar o CW
                {
                    a++;
                    break; // O break é a válvula de escape do looping
                }
                Console.WriteLine(a);
                a++;
                Console.ReadKey();
            }
        }
    }
}
