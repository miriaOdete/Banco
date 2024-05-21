using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Agencia
    {
        public int Numero { get; private set; }
        public string Nome { get; private set; }
        public string Telefone { get; private set; }

        public Agencia(int numero, string nome, string telefone)
        {
            if (numero <= 0)
            {
                throw new ArgumentException();
            }

            Numero = numero;
            Nome = nome;
            Telefone = telefone;
        }
    }
}