using System;

/*
    Oficina 2.2 do curso de Fundamentos de Desenvolvimento de Aplicações com Visual C#
    Trabalhando com classes, objetos e métodos.
*/

namespace Oficina_Aula2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando a classe Aluno
            Aluno novoAluno = new Aluno
            {
                nomeDoAluno = "João",
                email = "joaoferreira@mail.com",
                matricula = 20210218
            };

            novoAluno.inserirDisciplina("Algoritmos");
            novoAluno.removerDisciplina("Gestão de Projetos em TI");
            novoAluno.realizarMatricula();

            Aluno alunoMonitor = new Aluno
            {
                nomeDoAluno = "Carlos",
                email = "carlos.oliveira@mail.com",
                matricula = 20190121
            };

            alunoMonitor.inserirDisciplina("Trabalho de Conclusão de Curso");
            alunoMonitor.removerDisciplina("Programação para Dispositivos Móveis");

            // Instanciando a classe Professor
            Professor professor = new Professor
            {
                nomeDoProfessor = "Manuela",
                numeroCarteiraTrabalho = 410203102,
                salario = 1.800M
            };

            professor.realizarChamada();
            professor.postarConteudo("Organização e Arquitetura de Computadores");

            Professor novoProfessor = new Professor
            {
                nomeDoProfessor = "Pitágoras",
                numeroCarteiraTrabalho = 123010233,
                salario = 1.800M
            };

            novoProfessor.realizarChamada();
            novoProfessor.postarConteudo("Processos de Desenvolvimento de Software");

            Console.ReadLine();
        }
    }

    // Objetos
    public class Professor
    {
        public string nomeDoProfessor;
        public int numeroCarteiraTrabalho;
        public decimal salario;

        public void postarConteudo(string descricao)
        {
            Console.WriteLine(nomeDoProfessor + " está postando o conteúdo: " + descricao.ToUpper());
        }

        public void realizarChamada()
        {
            Console.WriteLine(nomeDoProfessor + " está realizando a chamada.");
        }
    }

    public class Aluno
    {
        public string nomeDoAluno;
        public string email;
        public int matricula;

        public void inserirDisciplina(string disciplina)
        {
            // Método para inserir disciplina
            Console.WriteLine("A disciplina " + disciplina + " foi incluída na grade de " + nomeDoAluno);
        }

        public void removerDisciplina(string disciplina)
        {
            // Método para remover disciplina
            Console.WriteLine("A disciplina " + disciplina + " foi removida da grade de " + nomeDoAluno);
        }

        public void realizarMatricula()
        {
            // Método para realizar matrícula
            Console.WriteLine("A matrícula do aluno " + nomeDoAluno + " Nº" + matricula + " foi realizada.");
        }
    }
}
