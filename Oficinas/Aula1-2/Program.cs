using System;

/*
    Oficina da Aula 1.2 do curso de Fundamentos de Desenvolvimento de Aplicações com Visual C#
    Cálculo da média escolar de um aluno e verificação de aprovação ou reprovação.
*/

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            string situacao;

            Console.WriteLine("Insira as notas do aluno para calcular sua média.");

            for (int i=0; i<5; i++)
            {
                Console.Write("Nota " + (i+1) + ": ");
                soma += Convert.ToDouble(Console.ReadLine());
            }

            double media = soma / 5;
            Console.WriteLine("A média do aluno foi " + media);

            if (media >= 6)
            {
                situacao = "Aprovado";
            } else
            {
                situacao = "Reprovado";
            }

            Console.WriteLine("Situação: " + situacao);

            Console.ReadLine();
        }
    }
}
