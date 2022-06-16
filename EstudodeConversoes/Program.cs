using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudodeConversoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            long Cpf;
            char sexo;

            Console.WriteLine("Insira o Nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Insira um CPF válido: ");
            Cpf = long.Parse(Console.ReadLine());
            Console.WriteLine("Indique o sexo: ");
            sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("O nome inserido é: " + nome);
            Console.WriteLine("O CPF informado é: " + Cpf);
            Console.WriteLine("O sexo informado é: " + sexo);

            Console.ReadKey();
        }
    }
}
