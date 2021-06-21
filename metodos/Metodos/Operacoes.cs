using System;

namespace Metodos.Operacoes
{
    public class Operacoes
    {
        public ResultadoMetodos Somar(int numero1, int numero2)
        {
            var resultadoSoma = RealizarOperacaoMatematica(numero1,numero2);
            return resultadoSoma;
        }

        public ResultadoMetodos Dividir(int numero1, int numero2)
        {
           var resultadoDivisao = RealizarOperacaoMatematica(numero1,numero2,2);
            return resultadoDivisao;
        }

        private ResultadoMetodos RealizarOperacaoMatematica(int numero1, int numero2, int operacao = 1) 
        {
            int resultado = 0;
            switch (Convert.ToInt32(operacao))
            {
                case 1:
                    resultado = numero1 + numero2;
                    break;
                case 2:
                    resultado = numero1 / numero2;
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    break;
                case 4:
                    resultado = numero1 - numero2;
                    break;

            }
            return new ResultadoMetodos()
            {
                Resultado = resultado,
                Operacao = (TipoOperacao)Enum.Parse(typeof(TipoOperacao), Convert.ToString(operacao))

            };
        }
    }

    public class ResultadoMetodos
    {
        public int Resultado { get;  }
        public TipoOperacao Operacao { get; set; }
    }

    public enum TipoOperacao
    {
        Soma = 1,
        Divisao = 2,
        Multiplicacao = 3,
        Subtracao = 4,
    }
}