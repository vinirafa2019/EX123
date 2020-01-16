using System;
using System.Collections.Generic;
using System.Text;

namespace EX1prova
{
    class Pessoa :Program
    {
        public string nome;
        public int idade;
        private List<Pessoa> pessoas;
        public Pessoa(String nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;          
        }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public List<Pessoa> Pessoas { get => pessoas; set => pessoas = value; }
    }
}
    

