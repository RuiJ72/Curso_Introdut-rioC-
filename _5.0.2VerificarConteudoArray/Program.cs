using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0._2VerificarConteudoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] a1 = new string[3];

            ////Formação do array
            //a1[0] = "Rui";
            //a1[1] = "Bethy";
            //a1[2] = "Sophie";

            //int size = a1.Length; // Método para verificar comprimeto// 
            //if(Array.Exists(a1, e=>e == "Bethy"))
            //{
            //    Console.WriteLine("Foi encontrado o nome Bethy no array");
            //}

            string[] a1 = new string[3];

            a1[0] = "Rui";
            a1[1] = "Bethy";
            a1[2] = "Sophie";

            int size = a1.Length;
            if(Array.Exists(a1, e=>e.IndexOf("ui") != -1))
            {
                Console.WriteLine("Foi encontrada parte da string que constitui Rui");
            }

            Console.ReadLine();

        }
    }
}
