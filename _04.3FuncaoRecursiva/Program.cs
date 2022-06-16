using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._3FuncaoRecursiva
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chamando a função
            Looping(1);
        }

        public static void Looping(int a) //A funçãotem de ser estática
        {
            Console.WriteLine(a);
            if(a < 3)
            {
                Looping(a + 1);
            }
            Console.ReadLine();
        }
    }
}
