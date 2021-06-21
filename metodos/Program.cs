using System;
using Metodos.Operacoes;

namespace metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            var metodo1 = new Operacoes();
            var resultado = metodo1.Dividir(4,2);
            Console.WriteLine($"Resultado da {resultado.Operacao} deu {resultado.Resultado}");
        }       
    }
}
