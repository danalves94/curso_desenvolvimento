using System;
using Classes;
using System.Collections.Generic;
using System.Linq;




namespace Biblioteca
{
    class Principal
    {
        IEnumerable<Livro> cadastroLivro = new List<Livro>();
        public static List<Livro> Livros { get; set; } = new List<Livro>();
        
        public static void Main()
        {            
            
            

            int usuarioCorreto;
            bool condicionalUsuario = true;
            while (condicionalUsuario)
            {
                Console.WriteLine($" Bem vindo ao Sistema ! Digite 1 para 'Administrador', Digite 2 para 'cliente' ou  digite '3' para sair");
                int.TryParse(Console.ReadLine(), out int loginAcesso);
                switch (loginAcesso)
                {
                    case 1:
                        Console.WriteLine("Digite sua senha");
                        string senhaAcesso = Console.ReadLine();
                        bool condicionalSenha = true;
                        while (condicionalSenha)
                        {
                            if (senhaAcesso == "12345")
                            {
                                usuarioCorreto = 1;
                                condicionalSenha = false;
                                condicionalUsuario = false;
                                Principal.MenuOpcao(usuarioCorreto);
                            }
                            else
                            {
                                Console.WriteLine("Senha invalida!");
                                Main();
                            }
                        }
                    break;
                    case 2:
                        usuarioCorreto = 2;
                        condicionalUsuario = false;
                        Principal.MenuOpcao(usuarioCorreto);
                    break;
                    case 3:
                        Environment.Exit(0);
                    break;
                    default:
                        Console.WriteLine("Usuario Invalido!");
                    break;
                }
            }            

        }
        public static int MenuOpcao (int usuarioCorreto)
        {
            switch(usuarioCorreto)
            {
                case 1:
                    Console.WriteLine("BEM VINDO AO MENU DE OPÇÕES");
                    Console.WriteLine("Digite '1' para cadastrar \r\n Digite '2' para Listar os livros \r\n Digite o '3' para excluir\r\n '4' Para trocar de usuario");
                    int.TryParse(Console.ReadLine(), out int opcaoMenu);
                    switch (opcaoMenu)
                    {
                        case 1:
                            Livro teste = new Livro();
                            int identificador = Livros != null && Livros.Any() ? Livros.LastOrDefault().Identificador +1 :1;
                            Livro livroCadastrado = Livro.CadastrarLivro(identificador);// alterei o tipo de variavel
                            Console.WriteLine(livroCadastrado.NomeLivro);
                            
                            if(Livros == null || !Livros.Any()) Livros = new List<Livro>();
                            Livros.ToList().Add(livroCadastrado);   // tirei o toList();
                                    
                        
                            Console.WriteLine("Digite '1', para voltar ao Menu ou '2' para sair");
                            int voltarMenu = Convert.ToInt32(Console.ReadLine());                                   
                        
                            switch (voltarMenu)
                            {
                                case 1:
                                MenuOpcao(usuarioCorreto);                   
                                
                                break;
                                case 2:
                                    Environment.Exit(0);
                                break;
                                default:
                                    Console.WriteLine("Opção invalida");
                                    
                                break;    

                            }
                            
                            break;
                        case 2:
                            
                            foreach (Livro livro in Livros)
                            {
                            Console.WriteLine($"Identificador: {livro.Identificador}; Nome do Livro:{livro.NomeLivro}; Valor do Livro:{livro.ValorAluguel}");
                            }
                            Console.WriteLine("Digite '1', para voltar ao Menu ou '2' para sair");
                            voltarMenu = Convert.ToInt32(Console.ReadLine());

                            switch (voltarMenu)
                            {
                                case 1:
                                MenuOpcao(usuarioCorreto);                   
                                
                                break;
                                case 2:
                                    Environment.Exit(0);
                                break;
                                default:
                                    Console.WriteLine("Opção invalida");
                                    
                                break;    

                            }
                            

                        break;
                        case 3:
                            Livro.Excluirlivro(Livros);

                            foreach (Livro livro in Livros)
                            {
                            Console.WriteLine($"Identificador: {livro.Identificador}; Nome do Livro:{livro.NomeLivro}; Valor do Livro:{livro.ValorAluguel}; Disponivel:{livro.StatusDisponibilidade}");
                            }

                            Console.WriteLine("Digite '1', para voltar ao Menu ou '2' para sair");
                            voltarMenu = Convert.ToInt32(Console.ReadLine());

                            switch (voltarMenu)
                            {
                                case 1:
                                MenuOpcao(usuarioCorreto);                   
                                
                                break;
                                case 2:
                                    Environment.Exit(0);
                                break;
                                default:
                                    Console.WriteLine("Opção invalida");
                                    
                                break;    
                            }

                        break; 
                        case 4:
                            Main();
                        break;   
                        default:
                            Console.WriteLine("Opção invalida!");
                        break;
                    }    
                        
                break;
                case 2:
                    Console.WriteLine(" Bem vindo ao sistema!");
                    Console.WriteLine("Digite '1' para Listar os livros disponiveis\r\n Digite '2' para Alugar os livros \r\n Digite o '3' para Devolver o Livro \r\n '4' voltar");
                    int.TryParse(Console.ReadLine(), out int opcaoMenuCliente);
                    
                    switch(opcaoMenuCliente)
                    {
                        case 1:
                            foreach (Livro livro in Livros)
                            {
                            Console.WriteLine($"Identificador: {livro.Identificador}; Nome do Livro:{livro.NomeLivro}; Valor do Livro:{livro.ValorAluguel}; Disponivel:{livro.StatusDisponibilidade}");
                            }

                            Console.WriteLine("Digite '1', para voltar ao Menu ou '2' para sair");
                            int voltarMenuCliente = Convert.ToInt32(Console.ReadLine());

                            switch (voltarMenuCliente)
                            {
                                case 1:
                                MenuOpcao(usuarioCorreto);                   
                                
                                break;
                                case 2:
                                    Environment.Exit(0);
                                break;
                                default:
                                    Console.WriteLine("Opção invalida");
                                    
                                break;   
                            }
                        break;
                        case 2:
                        //Não testei ainda
                            //Livro.AlugarLivro(Livros);
                            Console.WriteLine("Qual o Identificador do Livro que deseja alugar?");
                            int.TryParse(Console.ReadLine(), out int identificadorLivro);

                             //TimeSpan dataDoAluguel = new TimeSpan(DateTime.Now.Ticks);

                             //var livroretornado = Livros.Find(x => x.Identificador == identificadorLivro); 
                             foreach (Livro livro in Livros)
                             {
                                if(livro.Identificador == identificadorLivro)
                                {
                                    //livro.DataAluguel.Add(dataDoAluguel);
                                    livro.DataAluguel = Convert.ToDateTime(DateTime.Now.ToString());
                                    livro.StatusDisponibilidade = false;
                                    livro.DataEntrega = livro.DataAluguel.AddDays(7);
                                    Console.WriteLine("Alugado com sucesso!");
                                    MenuOpcao(usuarioCorreto);
                                }
                                else
                                {
                                    Console.WriteLine("Identificado invalido!");
                                    MenuOpcao(usuarioCorreto);

                                }
                             }                                                                                   
                        break;
                        case 3:
                            Console.WriteLine("Qual o Identificador do Livro que deseja alugar?");
                            int.TryParse(Console.ReadLine(), out int identificadorLivroDevolucao);

                            foreach (Livro livro in Livros)
                             {
                                if(livro.Identificador == identificadorLivroDevolucao)
                                {
                                    //livro.DataAluguel.Add(dataDoAluguel);
                                    livro.DataAluguel = default;
                                    livro.StatusDisponibilidade = true;
                                    livro.DataEntrega = default;
                                    Console.WriteLine("Livro devolvido com Sucesso!");
                                    MenuOpcao(usuarioCorreto);
                                }
                                else
                                {
                                    Console.WriteLine("Identificado invalido!");
                                    MenuOpcao(usuarioCorreto);

                                }
                             }                  
                        break;
                        default:
                        break;
                    }
                break;
                case 3:
                    Principal.Main();
                break;

                default:
                    Console.WriteLine("Resposta invalida! Fechando o Programa");
                    Environment.Exit(0);
                break;
            }    
        return default; 
        } 
                 
        
        
    }
}
