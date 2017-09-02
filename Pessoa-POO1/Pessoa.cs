using System;
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
        public Endereco Endereco { get; set; }
        public string CorDosOlhos { get; set; }

        public Pessoa()
        {
            Endereco = new Endereco();
        }

        public void Imprimir()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Data de Nascimento: " + DataNascimento.ToString("dd/MM/yyyy"));
            Console.WriteLine("Tipo Sanguineo: " + TipoSanguineo);
            Console.WriteLine("Cor dos olhos: " + CorDosOlhos);
            Console.WriteLine("Cpf: " + Cpf);
            Console.WriteLine("RG: " + RG);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine();
            Console.WriteLine("Idade: " + CalcularIdade());
        }

        public int CalcularIdade()
        {
            DateTime agora = DateTime.Today;
            int resultado = agora.Year - DataNascimento.Year;

            if (agora.DayOfYear < DataNascimento.DayOfYear)
            {
                resultado--;
            }
            return resultado;
        }
    }
}
