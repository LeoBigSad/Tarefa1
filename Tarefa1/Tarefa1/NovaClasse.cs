using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Tarefa1
{
    public class NovaClasse
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Profissao { get; set; }
        public NovaClasse(string nome, int idade, string profissao)
        {
            Nome = nome;
            Idade = idade;
            Profissao = profissao;
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Profissão: {Profissao}");
        }
    }
}


