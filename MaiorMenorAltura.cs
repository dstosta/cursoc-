using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_MaiorMenorAltura
{
    internal class MaiorMenorAltura
    {
        static void Main(string[] args)
        {
            // Declaração de vairaveis
            int matricula, matriculamaior, matriculamenor;
            string aluno;
            double altura, maior, menor;

            //inicialização de variaveis
            matriculamaior = 0;
            matriculamenor = 0;

            maior = 0;
            menor = 0;

            //logica principal
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Entre com a Matricula: ");
                matricula = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Entre com nome do aluno: ");
                aluno = Console.ReadLine();

                Console.WriteLine("Entre com a altura");
                altura = Convert.ToDouble(Console.ReadLine());

                if (i == 0)
                {
                    maior = altura;
                    menor = altura;
                }

                if (altura >= maior)
                {
                    maior = altura;
                    matriculamaior = matricula;
                }

                if (altura <= menor)
                {
                    menor = altura;
                    matriculamenor = matricula;
                }

            }

            Console.WriteLine("A maior matricula é: " + matriculamaior);
            Console.WriteLine("A menor matricula é: " + matriculamenor);
            Console.ReadKey();
        }
    }
}
