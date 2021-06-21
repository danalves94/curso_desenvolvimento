using System;
using System.Collections.Generic;
namespace Classes
{
    public class Livro
    {
        
        public int Identificador { get; set; }
        public string NomeLivro { get; set; }
        public bool StatusDisponibilidade { get; set; }
        public double ValorAluguel { get; set; }
        public DateTime DataAluguel { get; set; }
        public DateTime DataEntrega { get; set; }


        public static Livro CadastrarLivro(int ultimoIdentificador)
        {
            Livro teste = new Livro();  
            teste.Identificador = ultimoIdentificador++;
            Console.WriteLine("Digite o nome do Livro");
            teste.NomeLivro = Console.ReadLine();

            Console.WriteLine("Digite Valor");
            teste.ValorAluguel = Convert.ToDouble(Console.ReadLine());

            teste.StatusDisponibilidade = true;            
            return teste;
        }

        public static List<Livro> Excluirlivro(List<Livro> livrosCadastrados)
        {
            Console.WriteLine("Digite o Codigo identificador do livro");
            int identificadorLivro = Convert.ToInt32 (Console.ReadLine());

            var livroretornado = livrosCadastrados.Find(x => x.Identificador == identificadorLivro);

            livrosCadastrados.Remove(livroretornado);            

            return  livrosCadastrados ;
        }
        public static List<Livro> AlugarLivro(List<Livro> livrosCadastrados)
        {
            // Console.WriteLine("Qual o Identificador do Livro que deseja alugar?");
            // int.TryParse(Console.ReadLine(), out int identificadorLivro);

            // DateTime dataDoAluguel = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy"));

            // var livroretornado = livrosCadastrados.Find(x => x.Identificador == identificadorLivro);
            // foreach (var livro in livrosCadastrados)
            // {
            //     if (livros) == 
            // }
             return default;
        }
        public static string DevolucaoLivro(int identificadorLivro, DateTime dataEntrega)
        {
            return default;
        }
        

    }

    //  public static string LoginDeAcesso (string usuario, string senhaUsuario)
    // {

    // }

}