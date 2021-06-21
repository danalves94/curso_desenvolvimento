using System;

namespace calculo_salario_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorReajuste = 0;
            double salarioReajustado = 0;
            Console.WriteLine("Digite o cargo do Funcionario");
            string cargoFuncionario = Console.ReadLine();//poderia ter posto ".ToUpper" aqui tbem
            string cargoFuncionarioComparacao = cargoFuncionario.ToUpper();
            Console.WriteLine("Digite o valor do Salario do Funcionario");
            if (!double.TryParse((Console.ReadLine().Replace('.', ',')), out double salarioFuncionario))
            {
                Console.WriteLine("Digite um valor valido!");
                Main(args);
            }
            
            switch (cargoFuncionarioComparacao)
            {
                case "GERENTE":
                   // valorReajuste = salarioFuncionario * 0.50;
                   // salarioReajustado = salarioFuncionario + valorReajuste;
                    salarioReajustado = CalcularAumento(salarioFuncionario, 0.50);
                    valorReajuste = Reajuste(salarioFuncionario, 0.50);
                    Console.WriteLine($"O salario do cargo de {cargoFuncionario} teve um aumento de {Math.Round(valorReajuste, 2)} reais, ficando com um salario total de {salarioReajustado} Reais");
                    break;

                case "DESENVOLVEDOR":
                    //valorReajuste = salarioFuncionario * 0.40;
                    //salarioReajustado = salarioFuncionario + valorReajuste;
                    salarioReajustado = CalcularAumento(salarioFuncionario, 0.40);
                    valorReajuste = Reajuste(salarioFuncionario, 0.40);
                    Console.WriteLine($"O salario do cargo de {cargoFuncionario} teve um aumento de {Math.Round(valorReajuste, 2)} reais, ficando com um salario total de {salarioReajustado} Reais");
                    break;


                case "TECNICO":
                   // valorReajuste = salarioFuncionario * 0.30;
                   // salarioReajustado = salarioFuncionario + valorReajuste;
                    salarioReajustado = CalcularAumento(salarioFuncionario, 0.30);
                    valorReajuste = Reajuste(salarioFuncionario, 0.30);
                    Console.WriteLine($"O salario do cargo de {cargoFuncionario} teve um aumento de {Math.Round(valorReajuste, 2)} reais, ficando com um salario total de {salarioReajustado} Reais");
                    break;


                case "AUXILIAR ADMINISTRATIVO":
                    //valorReajuste = salarioFuncionario * 0.20;
                    //salarioReajustado = salarioFuncionario + valorReajuste;
                    salarioReajustado = CalcularAumento(salarioFuncionario, 0.20);
                    valorReajuste = Reajuste(salarioFuncionario, 0.20);
                    Console.WriteLine($"O salario do cargo de {cargoFuncionario} teve um aumento de {Math.Round(valorReajuste, 2)} reais, ficando com um salario total de {salarioReajustado} Reais");
                break;

                case "RECURSOS HUMANOS":
                    //valorReajuste = salarioFuncionario * 0.35;
                    //salarioReajustado = salarioFuncionario + valorReajuste;
                    salarioReajustado = CalcularAumento(salarioFuncionario, 0.35);
                    valorReajuste = Reajuste(salarioFuncionario, 0.35);

                    Console.WriteLine($"O salario do cargo de {cargoFuncionario} teve um aumento de {Math.Round(valorReajuste, 2)} reais, ficando com um salario total de {salarioReajustado} Reais");
                break;
                default:
                    //valorReajuste = salarioFuncionario * 0.10;
                    //salarioReajustado = salarioFuncionario + valorReajuste;
                    
                    salarioReajustado = CalcularAumento(salarioFuncionario, 0.10);
                    valorReajuste = Reajuste(salarioFuncionario, 0.10);

                    Console.WriteLine($"O salario do cargo de {cargoFuncionario} teve um aumento de {Math.Round(valorReajuste, 2)} reais, ficando com um salario total de {salarioReajustado} Reais");
                break;
            }


        }
        public static double CalcularAumento(double salario, double reajuste)
        {
            return salario + salario * reajuste;

        }
        public static double Reajuste (double salario, double reajuste)
        {
            return salario * reajuste;
        }
    

    }

}
