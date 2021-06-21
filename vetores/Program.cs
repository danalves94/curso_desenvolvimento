using System;
using System.Collections.Generic;
using System.Linq;

namespace vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayNomes = new string[5];

            // arrayNomes[0] = "Daniel";
            // arrayNomes[1] = "Vinicius";
            // arrayNomes[2] = "Ana";
            // arrayNomes[3] = "Rafael";
            // arrayNomes[4] = "Rodrigo";


            //[0][1][2][3][4]

            //indice 0 -> 0 < 5 true
            //indice 1 -> 1 < 5 true 
            //indice 2 -> 2 < 5 true 
            //indice 3 -> 3 < 5 true 
            //indice 4 -> 4 < 5 true 
            //indice 5 -> 5 < 5 false

            // for(int indice =0; indice < arrayNomes.Length; indice++) {
            //     Console.Write("Digite um nome: ");
            //     arrayNomes[indice] = Console.ReadLine();
            // }

            //Console.WriteLine(arrayNomes[0]);
            // Console.WriteLine(arrayNomes[1]);
            // Console.WriteLine(arrayNomes[2]);
            // Console.WriteLine(arrayNomes[3]);
            // Console.WriteLine(arrayNomes[4]);
            // for(int indice = 0; indice < arrayNomes.Length; indice++) {
            //     Console.WriteLine(arrayNomes[indice]);
            // }

            //Inverte o vetor
            // Array.Reverse(arrayNomes);

            //Copiando vetores
            // string [] arrayCopia = new string[5];

            //Observação - pode ser usado o tamanho do vetor ou um numero que voce escolher
            // Array.Copy(arrayNomes,arrayCopia,arrayNomes.Length);

            // //setando valores no vetor
            // arrayNomes.SetValue("Vinicius",2);
            // arrayNomes[2] = "Vinicius";

            // for(int indice = 0; indice < arrayCopia.Length; indice++) {
            //     Console.WriteLine(arrayCopia[indice]);
            // }

            // //aumentando o tamanho do vetor
            // Array.Resize(ref arrayCopia, 12);
            // Console.WriteLine(arrayCopia.Length);
            // arrayCopia[10] = "Teste";
            // Console.WriteLine(arrayCopia[10]);

            //Ordenar o vetor
            // int[] vetorInteiro = new int[5];

            // for (int indice = 0; indice < vetorInteiro.Length; indice++)
            // {
            //     Console.Write("Digite um numero: ");
            //     vetorInteiro[indice] = Convert.ToInt32(Console.ReadLine());
            // }

            // Array.Sort(vetorInteiro);

            // foreach(var numero in vetorInteiro) {
            //     Console.WriteLine(numero);             
            // }

            // int indice2 = Convert.ToInt32(vetorInteiro.GetValue(2));
            // Console.WriteLine($"Posição 3 do vetor: {indice2}");


            //*LISTAS*//

            //Iniciar uma lista
            List<int> lista1 = new List<int>();
            


            //filtrar items em uma lista    
            IEnumerable<int> numerosMaioresQue50 = lista1.Where(itemArray => itemArray >= 50);
            numerosMaioresQue50.ToList().ForEach(item => Console.WriteLine(item));
            lista1.Add(30);
            lista1.Remove(30);

            for (int indice = 0; indice < lista1.Count; indice++)
            {
                Console.Write("Digite um numero ou Sair para terminar: ");
                arrayNomes[indice] = Console.ReadLine();
            }

            foreach (var item in numerosMaioresQue50)
            {
                Console.WriteLine(item);
            }

            bool finalizarRepeticao = false;
            do
            {
                Console.Write("Digite um numero ou Sair para terminar: ");
                var respostaUsuario = Console.ReadLine();
                if (respostaUsuario.ToLowerInvariant() == "sair")
                {
                    finalizarRepeticao = true;
                }
                else
                {
                    lista1.Add(Convert.ToInt32(respostaUsuario));
                }
            }
            while (!finalizarRepeticao);

            int countLista = 0;
            while(countLista < lista1.Count) {
                Console.WriteLine($"Item na lista: {lista1[countLista]}");
                countLista++;
            }

            // foreach (var item in numerosMaioresQue50)
            // {
            //     Console.WriteLine(item);
            // }

            //Seleciona o primeiro item da lista
            lista1.FirstOrDefault();

            //Seleciona o ultimo item da lista
            lista1.LastOrDefault();

            //Console.WriteLine(lista1.Sum(itemArray => Convert.ToInt32(itemArray)));

            //Verifica se a lista tem item
            // if(lista1.Any())

            //Tamanho da lista
            //int tamanhoLista = lista1.Count;

            // if (lista1.Contains(30))
            // {
            //     lista1.Remove(30);
            //     foreach (var item in lista1)
            //     {
            //         Console.WriteLine(item);
            //     }
            // }


            // Console.WriteLine(arrayNomes[0]);
            // Console.WriteLine(arrayNomes[1]);
            // Console.WriteLine(arrayNomes[2]);
            // Console.WriteLine(arrayNomes[3]);
            // Console.WriteLine(arrayNomes[4]);


            //[0][1][2][3][4]



            // arrayNomes.SetValue(2,"0");
            // arrayNomes[0] = 2;

            // int[,] matriz = new int[3, 3];


            // //Atribuir valor em uma posição do array

            // List<string> lista = new List<string>();
            // lista.Add("Nome");


            // foreach(var item in lista) {
            //     Console.WriteLine(item);
            // }

            // for (var i = 0; i < array.Length; i++)
            // {
            //     Console.WriteLine(i);
            // }
            // Console.WriteLine();


            // var numero = 0;
            // foreach (var itens in array)
            // {
            //     Console.WriteLine(numero++);
            // }

            // string[] nomes = new string[5];
            // nomes[0] = "Ana";
            // nomes[1] = "Joao";
            // nomes[2] = "Roberto";
            // nomes[3] = "Carlos";
            // nomes[4] = "Mariana";
            // var countLista = 0;


            // countLista = 0;
            // do
            // {
            //     Console.WriteLine(nomes[countLista]);
            //     countLista++;
            // }
            // while (countLista < array.Length);

        }
    }
}
