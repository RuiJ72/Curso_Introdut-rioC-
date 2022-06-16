using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._1Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var a = 1;
            //switch (a)
            //{
            //    case 1:
            //        Console.WriteLine("caso 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("Caso 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("Padrão default");
            //        break;
            //}


            //Operadores ternários

            var a = 2;
            //string valor = "Rui";
            //if(a == 1)
            //{
            //    valor = "O valor de a";
            //}
            //else
            //{
            //    valor = "mais 1";
            //}
            
            // O mesmo que o bloco de condicionais em cima - Operador ternário
            string valor = (a == 1 ? "O valor de a" : "mais 1"); //Se o valor de a ==1 apresenta o valor 1 SE Não o valor será +1

            Console.WriteLine("Rui estipulou que o valor é: " + valor);
            Console.ReadLine();
        }
    }
}
