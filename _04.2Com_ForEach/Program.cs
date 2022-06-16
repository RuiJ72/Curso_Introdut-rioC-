using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._2Com_ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 }; // Criando um array
            foreach (int v in a) //Fará um for percorrendo todos os índicies do array
            {
                Console.WriteLine(v);
            }
            //Console.ReadLine();
            // Ou Com o  FOR

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);    
            }
            Console.ReadLine();

            
        }
    }
}
