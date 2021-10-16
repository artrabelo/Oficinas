using System;

/*
    Oficina 2.3 do curso de Fundamentos de Desenvolvimento de Aplicações com Visual C#

    [x] Implementação de duas classes para o sistema de uma loja virtual;
    [x] Criação de uma classe-mãe para os atributos comuns (nome e telefone) às duas classes;
    [x] As classes possuem atributos distintos: cpf (PessoaFisica) e cnpj (PessoaJuridica).
*/

namespace Oficina_Aula2_3

{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica representante = new PessoaFisica();
            representante.definirNome("Mateus");
            representante.definirCpf("01234567891");
            representante.definirTelefone(85828382);

            Console.WriteLine("Representante");
            Console.WriteLine("- Nome: " + representante.retornaNome());
            Console.WriteLine("- CPF: " + representante.retornaCpf());
            Console.WriteLine("- Telefone: " + representante.retornaTelefone());

            Console.WriteLine();

            PessoaJuridica loja = new PessoaJuridica();
            loja.definirNome("Compra e Venda");
            loja.definirTelefone(88923023);
            loja.definirCnpj("01426123000120");

            Console.WriteLine("Sobre a loja");
            Console.WriteLine("- Nome: " + loja.retornaNome());
            Console.WriteLine("- CNPJ: " + loja.retornaCnpj());
            Console.WriteLine("- Telefone: " + loja.retornaTelefone());

            Console.ReadLine();
        }
    }

    public class Pessoa
    {
        // Atributos da classe-mãe, comuns às classes-filhas
        private string nome;
        private int telefone;

        public void definirNome(string valorNome)
        {
            nome = valorNome;
        }

        public string retornaNome()
        {
            return nome;
        }

        public void definirTelefone(int valorTelefone)
        {
            telefone = valorTelefone;
        }

        public int retornaTelefone()
        {
            return telefone;
        }
    }

    public class PessoaFisica : Pessoa
    {
        private string cpf;
        
        public void definirCpf(string valorCpf)
        {
            cpf = valorCpf;
        }

        public string retornaCpf()
        {
            return cpf;
        }
    }

    public class PessoaJuridica : Pessoa
    {
        private string cnpj;

        public void definirCnpj(string valorCnpj)
        {
            cnpj = valorCnpj;
        }

        public string retornaCnpj()
        {
            return cnpj;
        }
    }
}
