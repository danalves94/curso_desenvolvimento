using System;

class MainClass {
  public static void Main (string[] args) {
    //Receber 2 notas de um aluno e calcular a media ponderada baseada nas notas

    // criei as variaveis no inicio pq de dentro do while nao puxa
    decimal primeiraNota = 0;
    decimal segundaNota = 0;
    decimal primeiroPeso = 0;
    decimal segundoPeso = 0;

    bool perguntaNota = true;
    while(perguntaNota)
    {
      Console.WriteLine("Qual é a primeira nota?");
      if(!decimal.TryParse(Console.ReadLine(), out  primeiraNota))
      {
        Console.WriteLine("Nota Invalida, favor inserir um numero");      
      }
      else
      {
        perguntaNota = false;
      }
    }   
   bool perguntaPeso = true;
   while(perguntaPeso)
   {
      Console.WriteLine("Qual é o peso da primeira nota?");  
     if(!decimal.TryParse(Console.ReadLine(), out  primeiroPeso))
      {
        Console.WriteLine("Peso Invalido, favor inserir um numero");      
      }  
     else
      {
        perguntaPeso = false;
      }
    }

   
   bool perguntaNota2 = true;
   while(perguntaNota2)
   {
      Console.WriteLine("Qual é a segunda nota?");  
      if(!decimal.TryParse(Console.ReadLine(), out  segundaNota))
      {
      Console.WriteLine("Nota Invalida, favor inserir um numero");
      
      }
      else
      {
        perguntaNota2 = false;
      }   
   }
   bool perguntaPeso2 = true;
   while(perguntaPeso2)
    {
      Console.WriteLine("Qual é o peso da segunda nota?");  
      if(!decimal.TryParse(Console.ReadLine(), out  segundoPeso))
      {  
        Console.WriteLine("Peso Invalido, favor inserir um numero");
        
      } 
      else
      {
        perguntaPeso2 = false;
      }
   }
   // deixei os metodos juntos
   decimal resultado1 = PesoVezesNota(primeiroPeso, primeiraNota);
   decimal resultado2 = PesoVezesNota(segundoPeso, segundaNota);
   decimal resultado = media(resultado1, resultado2, primeiroPeso, segundoPeso);

   //decimal resultado = ((primeiraNota * primeiroPeso) + (segundaNota * segundoPeso)) / (primeiroPeso + segundoPeso);

   Console.WriteLine($"A media ponderada das notas é {Math.Round(resultado,2)}.");
   
   
   Console.WriteLine("Deseja calcular outra media ponderada? Se sim responda '1', se não responda '2'");
   if(!decimal.TryParse(Console.ReadLine(), out decimal continuar))
   {
   Console.WriteLine("Opção digitada errada!");
   return;
   } 
   else if (continuar == 1)
   {
   Main(args);
   }
       

  }
  public static decimal PesoVezesNota(decimal nota, decimal peso)
  {
    return nota * peso;
  }
  public static decimal media(decimal resul1, decimal resul2, decimal peso1, decimal peso2)
  {
    return (resul1 + resul2) / (peso1 + peso2);
  }

}