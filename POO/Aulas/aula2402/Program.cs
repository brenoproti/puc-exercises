using System;

namespace aula2402
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Aluno
    {
        private string nome;
        private int numero;
        private Disciplina POO;
        private Disciplina Filo;
        private Disciplina BD;

        public Aluno() 
        {
            // POO = new Disciplina();
            // Filo = new Disciplina();
            // BD = new Disciplina();
        }

        public Aluno(string nome, int num, Disciplina nPOO, Disciplina nFilo, Disciplina nBD)
         {
            this.nome = nome;
            this.numero = num;
            this.POO = POO;
            this.Filo = Filo;
            this.BD = BD;
        }
    }

    class Professor
    {
        
    }

    class Disciplina
    {
        private String nome;
        private String codigo;
        private Professor professor;
    }
}
