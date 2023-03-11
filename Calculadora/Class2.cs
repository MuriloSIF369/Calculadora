using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculo
{
    public class Calculo
    {

        private double Resultado;
        public double ValorA;
        public double ValorB;
        public void CalcularSoma()
        {
            Resultado = ValorA + ValorB;
        }
        public void CalcularSubtracao()
        {
            Resultado = ValorA - ValorB;
        }
        public void CalcularMultiplicacao()
        {
            Resultado = ValorA * ValorB;
        }
        public void RetornarMaior()
        {
            int maior = int.MinValue;
            if (ValorA > maior)
            {
                Resultado = ValorA;
                if (Resultado > ValorB)
                {
                    Console.WriteLine(ValorA);
                }
                else
                {
                    Console.WriteLine(ValorB);
                }

            }
        }
            public void SomarGeral(double geral)
        {
            double G = geral;
            Resultado = G + ValorA + ValorB;
        }
        public void ImprimirResultado()
        {
            Console.Write(Resultado);
        }
    }

}
