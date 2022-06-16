using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1; //Tipagem estática
            //i = "s"; 

            var x = 2; //Tipagem dinâmica mas forte
            //x = "333"; // Ambas não aceitam uma string, pois o valor definido é um inteiro

            // Variável string estática
            string s = "Rui Lagos";
            var s2 = "Rui Lagos2"; // A mesma variável criada dinâmicamente


            // Variável float
            var f = 1.5; // Dinãmicamente
            float f2 = 1.6f; // Tipagem forte


            // Tipo Double
            var d = 1.7; // Dinâmica
            double d2 = 1.7; // Com tipagem forte


            // Viriável tipo char - para caracteres
            char c = 'c';

            // Viriáves booleanas
            var bo = true; // Criada dinâmicamente
            var bo2 = false;

            bool bo3 = true; // Com tipagem forte
            bool bo4 = false;

           


            
            
            Console.WriteLine(i);
            Console.WriteLine(x);
            Console.WriteLine(s);
            Console.WriteLine(s2);
            Console.WriteLine(f);
            Console.WriteLine(f2);
            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(c);
            Console.WriteLine(bo);
            Console.WriteLine(bo2);
            Console.WriteLine(bo3);
            Console.WriteLine(bo4);

            Console.ReadLine();
        }
    }
}
