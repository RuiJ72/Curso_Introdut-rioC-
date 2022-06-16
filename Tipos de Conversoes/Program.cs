using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.2.0Tipos_de_Conversoes
{
    internal class Program
    {
        private static object d;

        static void Main(string[] args)
        {
            // Tipos de Conversões

            //bool boolean = ((bool)"false"); // Com o Casting não poderemos converter pois não serve para tipos primitivos, ele serve para objetos

            // Usando o método Parse

            Boolean boolean = bool.Parse("false"); //Convertendo o boleano numa string
            Boolean boolean2 = Convert.ToBoolean("false"); // Usanado o Convert

            // O Parse recebe sempre uma string para converter em booleano. quando tratamos da conversão de um objeto para outro, usamos neste caso o Convert.ToBoolen
            // aceita igualmente outros tipos

            bool boo = bool.Parse("false");
            bool boo2 = Convert.ToBoolean(d);


            
            Animal a = new Animal();    // Criando o objeto
            Animal l = new Leao();

            //l = a; // Não é possível converter animal para leão
            a = l; //Faz um Casting pois leão herda de animal
            
            l = (Leao)a; // Mas dará erro pois animal não herda de leão mas sim o contrário

            a = l;


            
            Console.WriteLine(boolean);
            Console.WriteLine(boolean2);
            Console.WriteLine(boo2);
            Console.ReadLine();







        }
    }
    // Usando o Casting. Criando um objeto e convertendo
    public class Animal
    {

    }
    public class Leao : Animal
    {

    }
}
