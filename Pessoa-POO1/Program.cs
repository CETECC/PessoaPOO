﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_POO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();

            pessoa1.Nome = "Marcio, o Maravilhoso";
            pessoa1.TipoSanguineo = "A+";
            pessoa1.DataNascimento = new DateTime(1975, 11, 14);
            pessoa1.Cpf = "147.705.498-73";
            pessoa1.RG = "24.888.844-4";
            pessoa1.Endereco.Logradouro = "Travessa Leonardo Fabi";

                
            //"Travessa Leonardo Fabi, 53 - Vila Nivi - São Paulo/SP";
            pessoa1.CorDosOlhos = "Castanho";

            pessoa1.Imprimir();
        }
    }
}
