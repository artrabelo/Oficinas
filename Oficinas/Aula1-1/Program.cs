using System;

/*
    Oficina 1.1 do curso de Fundamentos de Desenvolvimento de Aplicações com Visual C#
    Multiplicação básica de dois valores.
*/

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recebendo valores do usuário
            Console.Write("Primeiro valor: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo valor: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Aplicando a função de multiplicação
            int resultado = Mult(num1, num2);
            Console.Write("Resultado: " + resultado);
        }
        static int Mult(int n1, int n2)
        {
            int res = n1 * n2;
            return res;
        }
    }
}