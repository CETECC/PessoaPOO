﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_POO1
{
    public class Pessoa
    {
        // Propriedades de uma Pessoa
        // *Obs.: Por convenção, usamos o nome da 
        // propriedade com a primeira letra de cada
        // palavra como sendo maiúscula, SEM ESPAÇOS.
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string TipoSanguineo { get; set; }
        public string Cpf { get; set; }
        public string RG { get; set; }
        public string Endereco { get; set; }

        public void Imprimir()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Data de Nascimento: " + DataNascimento);
            Console.WriteLine("Tipo Sanguineo: " + TipoSanguineo);
            Console.WriteLine("Cpf: " + Cpf);
            Console.WriteLine("RG: " + RG);
            Console.WriteLine("Endereço: " + Endereco);
        }
    }
}