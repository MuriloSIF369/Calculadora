using ConsoleCalculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculadora
{
    public class Calculadora : Calculo
    {
        public void LerValores()
        {
            Console.Write("Digite o valor A: ");
            ValorA = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor B: ");
            ValorB = double.Parse(Console.ReadLine());
        }
        public void ExecutarCalculadora()
        {
            Console.WriteLine("MENU DE OPÇÕES: ");
            Console.WriteLine("1 - Somar os valores. ");
            Console.WriteLine("2 - Subtrair os valores. ");
            Console.WriteLine("3 - Multiplicar os valores. ");
            Console.WriteLine("4 - Mostrar o maior valor. ");
            Console.WriteLine("5 - Somar geral os valores. ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CalcularSoma();
                    ImprimirResultado();
                    break;

                case 2:
                    CalcularSubtracao();
                    ImprimirResultado();
                    break;

                case 3:
                    CalcularMultiplicacao();
                    ImprimirResultado();
                    break;

                case 4:
                    RetornarMaior();
                    break;

                case 5:
                    Console.Write("Digite o valor a ser somado: ");
                    double variavel = double.Parse(Console.ReadLine());
                    SomarGeral(variavel);
                    ImprimirResultado();
                    break;
            }
        }
    }

}

