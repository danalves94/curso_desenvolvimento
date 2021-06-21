using System;
using System.Globalization;



class MainClass {
  public static void Main (string[] args) {
    
    double salarioBase = 0;
    double percentualVendas = 0;
    double vendasFeitas = 0;
    
    while(salarioBase == 0)
    {
      Console.WriteLine ("Qual é o salario base do vendedor? Exemplo de fotmato valido 1.045,00");
      if (!double.TryParse(Console.ReadLine(), out  salarioBase))
      {
       Console.WriteLine ("Salario Informado errado! Digite novamente");
      }
      
    }

    bool perguntaPercentualvendas = true;
    while(perguntaPercentualvendas)
    { 
      Console.WriteLine ("Qual é o percentual por vendas?");
      if (!double.TryParse(Console.ReadLine(), out percentualVendas))
      {
        Console.WriteLine($"Percentual de venda errado! Digite novamente");
      }
      else
      {
        perguntaPercentualvendas = false;
      }
      
    }
    
    
    bool perguntaVendasFeitas = true;
    while(perguntaVendasFeitas)
    {
      Console.WriteLine ("Quantas vendas foram feitas?");
      if (!double.TryParse(Console.ReadLine(), out vendasFeitas))
      {
        Console.WriteLine("Quantidade de vendas errada!");
      }
      else
      {
        perguntaVendasFeitas = false;
      }
      
    }
    double resultadoPercentual = ContaPercentual(percentualVendas, salarioBase);
    double salarioVendas = SalarioPorVendas(resultadoPercentual, vendasFeitas);
    double salarioTotal = SalarioFinal( salarioVendas, salarioBase);
    
    Console.WriteLine($"O valor encima do percentual por vendas é {salarioVendas:n} reais, o salario total é {salarioTotal:n} reais.");

    
  }
  public static double ContaPercentual (double vendas, double salario)
    {
      return (vendas / 100) * salario;
    }

  public static double SalarioPorVendas (double percentual, double vendas)
  {
    return percentual * vendas;
  }  
  public static double SalarioFinal (double vendas, double salarioBase)
  {
    return vendas * salarioBase ;
  }  
}




    
      
     
      
    
    

    