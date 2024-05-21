using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Cliente(string nome, string cpf)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException();
            }

            if (string.IsNullOrWhiteSpace(cpf))
            {
                throw new ArgumentException();
            }

            Nome = nome;
            Cpf = cpf;
        }
    }
}
