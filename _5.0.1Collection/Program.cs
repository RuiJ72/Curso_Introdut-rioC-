using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0._1Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a1 = new string[3];
            a1[0] = "Rui";
            a1[1] = "Rui2";
            a1[2] = "Rui";

            // para ver a quantidade em Arrays
            int size = a1.Length;



            // Criando uma lista
            List<string> a = new List<string>();
            a.Add("Rui");
            a.Add("Bethy");
            a.Add("Sophie");

            //Console.WriteLine(a[0]); // Mostrando o índice 0 
            // Com um FOREACH para mostrar o conteúdo do array

            foreach(string nome in a)
            {
                Console.WriteLine(nome);
            }

            // Transformando uma lista em um Array a.ToArray();


            if (a.Exists(e => e == "Rui"))
            {
                Console.WriteLine("Foi encontrado o nome Rui na lista");
            }
            
            
            
            
            // Para ver a quantidade em List
            int size_list = a.Count;




            Console.ReadLine();
        }
    }
}
