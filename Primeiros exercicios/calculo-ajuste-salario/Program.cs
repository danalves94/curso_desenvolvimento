using System;

namespace calculo_ajuste_salario
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double valorReajuste = 0;
            double salarioReajustado = 0;
            double salarioFuncionario = 0;
            decimal codigoFuncionario = 0;
            bool condicaoSalario = true;
            while(condicaoSalario)
            {
                Console.WriteLine("Digite o salario do Funcionario");
                if (!double.TryParse((Console.ReadLine().Replace('.',',')), out  salarioFuncionario))
                {
                    Console.WriteLine("Digite um salario valido!");
                    
                }
                else
                {
                    condicaoSalario = false;
                }

                if (salarioFuncionario < 300)
                {
                    Console.WriteLine("Salario com o valor abaixo do permitido");
                    
                }
                else
                {
                    condicaoSalario = false;
                }
            }
            bool condicaoFuncionario = true;
            while(condicaoFuncionario)
            {
                Console.WriteLine("Digite o codigo do funcionario");
                if (!decimal.TryParse(Console.ReadLine(), out codigoFuncionario))
                {
                    Console.WriteLine("Favor digitar numeros, sem pontuações.");

                }
                else
                {
                    condicaoFuncionario = false;
                }
            }
                if (salarioFuncionario > 2001)
                {
                    Console.WriteLine($"O funcionario {codigoFuncionario} não teve aumento, devido a diretrizes de aumento da empresa");
                    return;
                }              

                if (salarioFuncionario == 300.00)
                {
                    valorReajuste = salarioFuncionario * 0.10;
                    salarioReajustado = salarioFuncionario + valorReajuste;
                }
                else if (salarioFuncionario > 300.00 && salarioFuncionario < 600.01)
                {
                    valorReajuste = salarioFuncionario * 0.11;
                    salarioReajustado = salarioFuncionario + valorReajuste;
                }
                else if (salarioFuncionario > 600.00 && salarioFuncionario < 900.01)
                {
                    valorReajuste = salarioFuncionario * 0.12;
                    salarioReajustado = salarioFuncionario + valorReajuste;
                }
                else if (salarioFuncionario > 900.00 && salarioFuncionario < 1500.01)
                {
                    valorReajuste = salarioFuncionario * 0.06;
                    salarioReajustado = salarioFuncionario + valorReajuste;
                }
                else if (salarioFuncionario > 1500.00 && salarioFuncionario < 2000.01)
                {
                    valorReajuste = salarioFuncionario * 0.03;
                    salarioReajustado = salarioFuncionario + valorReajuste;
                }
                
                Console.WriteLine($"O Funcionario {codigoFuncionario}, teve um aumento de {Math.Round (valorReajuste,2)} Reais e agora seu salario é {salarioReajustado} Reais.");
                Console.WriteLine("Gostaria de olhar o ajuste de outro funcionario? responda com SIM."); 
                if (Console.ReadLine() == "sim")
                {
                    Main(args);


                }
                else
                {
                    Console.WriteLine("Você digitou um texto invalido! ou não quis pesquisar novamente! fechando o sistema.");
                   // Environment.Exit(0);  // posso chamar em qualquer parte do codigo
                    return;  //  só usa dentro do main  
                    
                           
                }

            
            



        }
    }
}


