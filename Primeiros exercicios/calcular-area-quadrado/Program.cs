using System;

class MainClass {
  public static void Main (string[] args) {
    //Receber as medidas de um quadrado e calcular sua area
    decimal ladoQuadrado = 0;
    // // (int indice = 0; indice < 4; indice++)
    // {
    //   Console.WriteLine ("qual a medida de um lado do quadrado?");
    //   if(!decimal.TryParse(Console.ReadLine(), out ladoQuadrado))
    //   {
    //     int tentativa = 3;
    //     tentativa -=indice;
    //     Console.WriteLine($"Medida Incorreta! Favor digitar numero. Você tem mais {tentativa} tentativas");
    //   }
    // //   //else
    // //  // {
    // //  //   indice = 4;
    // //   }         
      
    //}

    bool continuarRepeticao = true;
    while(continuarRepeticao)
    {
      Console.WriteLine ("qual a medida de um lado do quadrado?");
      if(!decimal.TryParse(Console.ReadLine(), out ladoQuadrado))
      {
        Console.WriteLine($"Medida Incorreta! Favor digitar numero.");
      }
      else
      {
        continuarRepeticao = false;
      }
    }
     //decimal ladoQuadrado = Convert.ToDecimal (Console.ReadLine());
      decimal area = ladoQuadrado * ladoQuadrado;

    Console.WriteLine ($" A area do Quadrado é {area}");
    Console.WriteLine ("Deseja calcular a aréa de outro quadrado? Digite '1' pra sim e '2' para não");
    if (!int.TryParse(Console.ReadLine(), out int continuar))
    {
      Console.WriteLine("Opção invalida!");
      return;
    }
    if (continuar == 1)
    {
      Main(args);
    } 
    else      
    {
      return;
    }
    
  }
}
