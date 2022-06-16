using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Condicionais

            //var a = 2; // Consoante o valor atribuido à variável, será executado apenas o primeiro ou o segundo bloco
            //if (a == 1) // Consoante se a condição for ou não válida um ou o outro outro bloco será executado
            //{
            //    Console.WriteLine("Entrámos na condição do IF");
            //    Console.WriteLine("#####");
            //}
            //else
            //{
            //    Console.WriteLine("Entrámos no bloco do Else");
            //    Console.WriteLine("#####");
            //}


            //Usando else if
            var a = 3; // Cai no terceiro bloco
            if (a == 1)
            {
                Console.WriteLine("Entrámos na condição do IF");
                
            }
            else if(a == 2) 
            {
                Console.WriteLine("Cai no bloco do Se Não se a = 2");
            }
            else
            {
                Console.WriteLine("a não é igual a 3");
            }



            Console.ReadLine();
        }
    }
}
