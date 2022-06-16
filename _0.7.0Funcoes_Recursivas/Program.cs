using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._7._0Funcoes_Recursivas
{
    class Program
    {
        private static void LerArquivo(string nomeArquivo)
        {
            // Código para ler o arquivo que foi criado externamente
            using (StreamReader arquivo = File.OpenText(nomeArquivo)) // Abrindo o arquivo
            {
                string linha;
                while ((linha = arquivo.ReadLine()) != null) //Lê uma linha e passa para a próxima linha
                {
                    Console.WriteLine(linha); // Mostra a linha lida
                }
            }
        }

        static void Main(string[] args)
            {
                // Função que chama a sí própria até ser satisfeita uma condição(pode ter dentro um looping mas não é um looping)
                // Diminui a repetição de código

                LerArquivo(@"C:\Users\Rui Lagos\Documents\Curso de c#\Arquivos\Arq1.txt.txt");
                Console.ReadKey();
            }
        }
    }

