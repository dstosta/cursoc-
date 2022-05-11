using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3___Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num2, resultado;
            string operacao;

            operacao = "";

            Console.WriteLine("Entre com nome o primeiro numero: ");
            resultado = Convert.ToDouble(Console.ReadLine());

            while (operacao != "=")
            {
                Console.WriteLine("Entre com a operação matematica ou com o sinal de igual para finalizar: ");
                operacao = Console.ReadLine();

                if (operacao == "=")
                {
                    break;
                }

                Console.WriteLine("Entre com o próximo numero: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                try
                {
                    resultado = Aula_3___Calculadora.DecideOperacao.ConfirmaOperacao(operacao, resultado, num2);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh não! Ocorreu uma exceção ao tentar fazer as contas.\n - Detalhes: " + e.Message);
                }


            }
            Console.WriteLine("O resultado é: " + resultado);
            Console.ReadKey();
        }
    }

    public class DecideOperacao
    {
        private string operacao;
        public string Operacao { get { return operacao; } set { operacao = value; } }
        
        public static double ConfirmaOperacao (string operacao, double num, double num1)
        {
            if (operacao == "+")
            {
                num = num + num1;
            }
            else if (operacao == "-")
            {
                num = num - num1;
            }
            else if (operacao == "*")
            {
                num = num * num1;
            }
            else if (operacao == "/")
            {
                if (num1 == 0)
                {
                    num1 = 1;
                }
                num = num / num1;
            }
            return num;
        }

    }
}
