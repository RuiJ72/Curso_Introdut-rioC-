using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0Arrays_E_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            string[] a = new string[3]; // Array com 4 posições

            //Colocando dados nos índices do array
            a[0] = "Rui";
            a[1] = "Bethy";
            a[2] = "Sophie";


            Array.Sort(a); // Ordena por ordem ascendente

            // Parta mostrar o conteúdo do array
            // Ordenando a ordem dos elementos do array. 
            foreach(string nome in a)
            {
                Console.WriteLine(nome);
            }
 

          

            Console.ReadLine();
        }
    }
}
