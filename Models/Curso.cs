using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public required string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
            return true;
    
        }

        public void ListarAlunos()
        
        
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");

            for (int count = 0; count < Alunos.Count; count++)
            {
              //  string texto = "N° " + count + " - " + Alunos[count].GetNomeCompleto(); < Concatenação abaixo Interpolação
              string texto = $"N° {count + 1} - {Alunos[count].GetNomeCompleto()}";
                Console.WriteLine(texto);
            }

           
        }



    }
}