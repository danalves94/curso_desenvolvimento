using System;

class MainClass {
  public static void Main (string[] args) {
    //Receber dois numeros e realizar as 4 operaçoes matematicas e informar os resultados para o usuario

    decimal soma, subtracao, divisao, multiplicacao;
    decimal numero1 = 0;
    bool condicaoNumero = true;
    while(condicaoNumero)
    {
      Console.WriteLine ("Digite o primeiro numero:");
      if(! decimal.TryParse(Console.ReadLine(), out numero1))
      {
        Console.WriteLine("Numero invalido!");
      }
      else
      {
        condicaoNumero = false;
      }
    }
    decimal numero2 = 0;
    bool condicaoNumero2 = true;
    while(condicaoNumero2)
    {
      Console.WriteLine ("Digite o segundo numero:");
      if(! decimal.TryParse(Console.ReadLine(), out numero2))
      {
        Console.WriteLine("Numero Invalido");
      }
      else
      {
        condicaoNumero2 = false;    
      }  
    }
     soma = numero1 + numero2;
     subtracao = numero1 - numero2;
     divisao = numero1 / numero2;
     multiplicacao = numero1 * numero2;
     Console.WriteLine ($"A soma dos números é {soma}");
     Console.WriteLine ($"A subtração dos números é {subtracao}");
     Console.WriteLine ($"A Divisão dos números é {divisao}");
     Console.WriteLine ($"A  multiplicação dos números é {multiplicacao}");
  }
}