using System;

class MainClass {
  public static void Main (string[] args) {
    //Receber dois numeros, calcular o quadrado dos dois e retornar a diferença para o usuario
    decimal primeiroNumero = 0;
    bool condicaoNumero = true;
    while (condicaoNumero)
    {  
      Console.WriteLine ("Digite o primeiro número"); 
      if(! decimal.TryParse(Console.ReadLine(), out primeiroNumero))   
      {
        Console.WriteLine("Digite um numero valido!");
      }
      else
      {
        condicaoNumero = false;
      } 
    }
    decimal segundoNumero = 0;
    bool condicaoNumero2 = true;
    while(condicaoNumero2)
    {         
      Console.WriteLine ("Digite o segundo número");
      if (!decimal.TryParse(Console.ReadLine(), out segundoNumero))
      {
        Console.WriteLine("Numero Invalido!");
      }
      else
      {
        condicaoNumero2 = false;
      }  
    } 
    decimal primeiroAoQuadrado = primeiroNumero * primeiroNumero;
    decimal segundoAoQuadrado = segundoNumero * segundoNumero;
    decimal resultado = primeiroAoQuadrado - segundoAoQuadrado;
    resultado = resultado * 1;

    Console.WriteLine ($"O primeiro ao quadrado é {primeiroAoQuadrado}, o segundo numero ao quadrado é {segundoAoQuadrado} e a diferança é {resultado}");


  }
}