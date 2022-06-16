using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._9Declaracao_De_Variaveis_E_Constantes
{
    internal class Program
    {
        public const int SAIDA_PROGRAMA = 1; // Declaração de variável do tipo int
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite " + SAIDA_PROGRAMA + " spara sair do programa");
                int valor = int.Parse(Console.ReadLine());

                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}

