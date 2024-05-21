using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        public long Numero { get; private set; }
        public Agencia Agencia { get; private set; }
        public Cliente Cliente { get; private set; }
        public decimal Saldo { get; private set; }

        public Conta(long numero, Agencia agencia, Cliente cliente, decimal saldo)
        {
            if (agencia == null)
            {
                throw new ArgumentNullException(nameof(agencia), "A conta deve pertencer a uma agência.");
            }

            if (cliente == null)
            {
                throw new ArgumentNullException(nameof(cliente), "A conta deve pertencer a um cliente.");
            }

            Numero = numero;
            Agencia = agencia;
            Cliente = cliente;
            Saldo = saldo;
        }

        public void Deposito(decimal valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor do depósito deve ser maior que zero.");
            }

            Saldo += valor;
        }

        public void Saque(decimal valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor do saque deve ser maior que zero.");
            }

            if (Saldo < valor)
            {
                throw new InvalidOperationException("Saldo insuficiente para saque.");
            }

            Saldo -= valor;
        }
    }
}
