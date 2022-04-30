using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_AumentoSalario
{
    internal class AumentoSalario
    {
        static void Main(string[] args)
        {
            // Declaração de vairaveis

            string funcionario;
            double salario, salarioreajustado;

            //inicialização de variaveis
            salarioreajustado = 0;


            //logica principal
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Entre com nome do funcionario: ");
                funcionario = Console.ReadLine();

                Console.WriteLine("Entre com o salario do funcionario: ");
                salario = Convert.ToDouble(Console.ReadLine());

                if (salario <= 300)
                {
                    salarioreajustado = salario * 1.5;
                }

                if (salario > 300)
                {
                    salarioreajustado = salario * 1.3;
                }
                Console.WriteLine("O funcionário " + funcionario + " tinha o salario antigo de: R$ " + salario + " o novo salario reajustado é: R$ " + salarioreajustado);

            }
            Console.ReadKey();
        }
    }
}
