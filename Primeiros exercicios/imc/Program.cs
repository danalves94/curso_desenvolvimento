using System;
using System.Globalization;



class calculo {
   static void Main(string[] args)
        {
            double peso = 0;
            double altura = 0;
            double imc = 0;
            //string pe = ""; // teria necessidade dessa variavel?
            //string al = "";// teria necessidade dessa variavel?

            Console.WriteLine("Digite seu peso");

            //Validação do que o usuário digitou
            //Se é possivel converter para double, a função TryParse pega o valor convertido e joga na variavel resultadoPeso
            if(!double.TryParse(Console.ReadLine(), out double resultadoPeso)) {
                Console.WriteLine("Peso informado incorretamente."); 
            }
            else {
            peso = resultadoPeso;
            Console.WriteLine("Digite sua altura");       
            //Outra forma de converter tipos de variaveis  
            //altura = Convert.ToDouble(Console.ReadLine());   
            string auxAltura = Console.ReadLine();  
            altura = Convert.ToDouble(auxAltura.Replace(".",",") , new CultureInfo("pt-BR"));

            Console.WriteLine(altura);
            imc = peso / (altura * altura);
            Console.WriteLine("Seu IMC é " + imc);
            //Console.WriteLine(pe.GetType()); mostra o tipo da variavel - Ex: System.String
            //Console.WriteLine(al.GetType());
            }
           
      }
}