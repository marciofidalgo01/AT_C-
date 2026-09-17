using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Program{
    public static void Main(string[] args){
       
            Aluno aluno1 = new Aluno("Marcio", "abc", "EDS", 8);

            Aluno aluno2 = new Aluno("Pedro", "abc", "EDC", 5);

            aluno1.ExibirDados();
            aluno1.VerificarAprovacao();

            aluno2.ExibirDados();
            aluno2.VerificarAprovacao();
        }

        public class Aluno
        {
            public string Nome { get; set; }
            public string Matricula { get; set; }
            public string Curso { get; set; }
            public double MediaNotas { get; set; }

            public Aluno(string nome, string matricula, string curso, double mediaNotas)
            {
                Nome = nome;
                Matricula = matricula;
                Curso = curso;
                MediaNotas = mediaNotas;
            }

            public void ExibirDados()
            {
               Console.WriteLine($"Nome: {Nome}");
               Console.WriteLine($"Matricula: {Matricula}");
               Console.WriteLine($"Curso: {Curso}");
               Console.WriteLine($"MediaNotas: {MediaNotas}");
            }


            public void VerificarAprovacao()
            {
                if(MediaNotas >= 7)
                {
                    Console.WriteLine("Aluno aprovado \n");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado \n");
                }

            }
        }  
}

