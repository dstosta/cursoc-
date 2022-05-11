using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3Boletim
{
    internal class Boletim
    {
        static void Main(string[] args)
        {
            aluno al1 = new aluno();

            Console.WriteLine("Entre com nome do aluno ");
            al1.Nomealuno = Console.ReadLine();

            Console.WriteLine("Entre com a matricula do aluno  ");
            al1.Matricula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrando com as 5 displinas que compoe o boletim.");

            disciplina[] d1 = new disciplina[5];

            for (int i = 0; i < d1.Length; i++)
            {
                d1[i] = new disciplina();

                Console.WriteLine("Entre com disciplina ");
                d1[i].NomeDisciplina = Console.ReadLine();

                Console.WriteLine("Entre com a primeira nota da disciplina  " + d1[i].NomeDisciplina);
                d1[i].Nota1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Entre com a primeira nota da disciplina  " + d1[i].NomeDisciplina);
                d1[i].Nota2 = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("");
            Console.WriteLine("Matricula: " + al1.Matricula + " - nome do aluno é: " + al1.Nomealuno );

            for (int i = 0; i < d1.Length; i++)
            {
                Console.WriteLine("Disclina:  " + d1[i].NomeDisciplina);
                Console.WriteLine("Primeira nota: " + d1[i].Nota1);
                Console.WriteLine("Segunda nota: " + d1[i].Nota2);
                Console.WriteLine("Media nota: " + Aula3Boletim.disciplina.MediaDiscipina(d1[i].Nota1, d1[i].Nota2));

                Console.WriteLine("");

            }

            Console.ReadKey();
        }
        
    }

    public class aluno
    {
        private int matricula;
        private string nomealuno;

        public int Matricula { get => matricula; set => matricula = value; }
        public string Nomealuno { get => nomealuno; set => nomealuno = value; }
              
    }

    public class disciplina
    {
        private string nomeDisciplina;
        private double nota1;
        private double nota2;


        public string NomeDisciplina { get => nomeDisciplina; set => nomeDisciplina = value; }
        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }

        public static double MediaDiscipina(double n1, double n2)
        {
            double media;

            media = (n1 + n2) / 2;
            return media;
        }

    }
        
}
