using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {

        public Pessoa()
        {
            
        }

        public Pessoa(string nome, string sobrenome)
        {
           Nome = nome;
           Sobrenome = sobrenome; 
        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome =  Nome;
            sobrenome = Sobrenome;

        }
        
        private string _nome;
       // private int _idade;
        public required string Nome 
        {   
            
            get  => _nome.ToUpper();


            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome não pode ser vazio");
                }

                _nome = value;

            }

        }

        public required string Sobrenome { get; set; }

        public string GetNomeCompleto()
        {
            return $"{Nome} {Sobrenome}".ToUpper();
        }

        // public required int Idade 
        // { 
        //     get => _idade;


        //     set
        //     {
        //         if(value < 0)
        //         {
        //             throw new ArgumentException("Idade não pode ser menor que zero");
        //         }
        //         _idade = value;
        //     } 
        //  }

        // public void Apresentar()
        // {
        //     Console.WriteLine($"Nome:  {GetNomeCompleto()}, Idade: {Idade}");
        // }
    }
}