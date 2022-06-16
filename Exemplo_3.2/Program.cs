using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var a = 2 + 3;// Testar utilizando os 4 operadores matemáticos
            //if(a != 2)  // ou desta forma (!(a == 2)) 
            //{
            //    Console.WriteLine("Restornará um boleano negando a condição");
            //}



            ////Console.WriteLine("O valor é " + a);
            //Console.ReadLine();


            // Outro exemplo com boleanos
            var a = 3;
            if (a == 2 && a == 3)
            {
                Console.WriteLine("A afirmação´lógica é Falsa e não entrará no IF");
            }
            else if (a == 3 || a == 1)
            {
                Console.WriteLine("Uma das afirmações é verdadeira: True");
            }  
            Console.ReadLine();
        }
    }
}
