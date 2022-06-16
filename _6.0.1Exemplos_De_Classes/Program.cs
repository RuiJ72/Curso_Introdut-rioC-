using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._0._1Exemplos_De_Classes
{

    class Program2 //Tentando instanciar a classe do programa original 
    {
        static void Main(string[] args)
        {   
            //Program.// Vai mostrar tudov o que for Public

            var PG = new Program();
            //PG // Ao digitar PG não mostra nenhum dos métodos pois a função é estática
        }
    }   class Program
        {
            // Exemplo de Class protected: vai funcionar protegida por este programa
            // Só funcionará no contexto do objeto namespace
            // Como private, funcionrá apenas para esta classe

             static int calcular()
            {
                int a = 1;
                int b = 2;
                int c = a + b;


                return c; //retorna o valor da soma das duas outras funções a e b
            }

            public static void MostrarMensagemNaTela()
            {
                Console.WriteLine("Exemplo do resultado de uma função mostrando a tabuada dos 9");
            }

            // Criando uma função para executar a tabuada
            public static void Tabuada(int numero)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(numero + " x " + i + " = " + (numero * i));
                }
                Console.WriteLine("############################################");
            }


            static void Main(string[] args)
            {
                Console.WriteLine(calcular());
                MostrarMensagemNaTela(); // Chamada da função

                Tabuada(9); // Passando um parâmetro neste caso a tabuada dos 9
                Tabuada(8);
                Tabuada(10);
                // Se não fosse usada uma função, teriamos de repetir o For

                Console.ReadLine();

            }
        }
    }



