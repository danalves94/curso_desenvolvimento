using System;
using System.Collections.Generic;

namespace DesafioArvoreNatal
{
    class Program
    {  
        public static void Main (string[] args) {
            Console.WriteLine ("Desafio Arvore de natal");
            Console.WriteLine ("Quantos '*' são na Base?");
            int numeroColunas = Convert.ToInt32(Console.ReadLine());

            int numeroLinhas = ((numeroColunas - 1) / 2) +1;

            for (int linha = 0; linha <= numeroLinhas; linha++)
            {
                for (int vazio = 0; vazio < numeroLinhas - linha; vazio++)// controle dos vazios, a impressão  do primeiro * é igual ao numero de linhas, depois eu só venho decrementando com vazios.
                {
                    Console.Write(" ");
                }
                for (int asteriscos = 0; asteriscos < (linha * 2) -1 ; asteriscos++)// multipliquei linha por 2, pq a cada linha aumenta 2 asteriscos. Esse menos 1 é pq na primeira linha começa com apenas 1 asteriscos e apartir da segunda é pq acabatendo que decrementar a quantidade de linha
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Deseja fazer outra arvore? pressione '1' para Sim e '2' para sair");
            int retornoPergunta = Convert.ToInt32 (Console.ReadLine());

            switch (retornoPergunta)
            {
                case 1:
                    Main(args);
                break;
                case 2:
                   // return;
                    Environment.Exit(0);
                break;
                default:
                    Console.WriteLine("Resposta invalida");
                break;
            }
        }
    }    
} 
               

          
   

