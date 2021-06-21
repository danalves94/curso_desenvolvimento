using System;
using exercicio.Classe;
//using System.Linq;
//using System.Collections.Generic;
//using System.Globalization;

namespace Metodos.Perguntas
{
    class Program
    {
        static void Main(string[] args)
        {   
            Aluno objetoTeste = new Aluno();
            Aluno [] dadosAlunos = new Aluno[4];
            
            for(int indice = 0; indice < dadosAlunos.Length; indice++)
            {
               dadosAlunos[indice] = new Aluno(); 
               Console.WriteLine($"Digite a altura do aluno {indice + 1}");
               dadosAlunos[indice].AlturaAluno = Convert.ToDouble(Console.ReadLine());

               Console.WriteLine($"Digite a matricula do aluno {indice + 1}");
               dadosAlunos[indice].MatriculaAluno = Convert.ToDouble(Console.ReadLine());
            }

            double valorAlturaMaior = 0;
            double valorAlturamenor = 0;
            int indiceAlturaMaior = 0;
            int indiceAlturaMenor = 0;
           for( int indice = 0; indice < dadosAlunos.Length; indice++)
            {                
                if (dadosAlunos[indice].AlturaAluno > valorAlturaMaior)
                {
                    valorAlturaMaior = dadosAlunos[indice].AlturaAluno;//validação certa, mas feita errada, a ideia aqui é pegar o indice e nao o valor.                  
                    indiceAlturaMaior = indice; 
                }
                if (dadosAlunos[indice].AlturaAluno < valorAlturamenor)
                {
                    valorAlturamenor = dadosAlunos[indice].AlturaAluno;
                    indiceAlturaMenor = indice;
                }
            }
            Console.WriteLine($"A matricula do aluno com a maior altura é {dadosAlunos[indiceAlturaMaior].MatriculaAluno}");
            Console.WriteLine($"E a matricula do aluno com a menor altura é {dadosAlunos[indiceAlturaMenor].MatriculaAluno}.");  
        }
    }
}               
                   
            
           
            
        
