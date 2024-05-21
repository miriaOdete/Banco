using Banco;
class Program
{
        static void Main(string[] args)
        {
            try
            {
                // Solicitar informações da agência
                Console.Write("Digite o número da agência: ");
                int numeroAgencia = int.Parse(Console.ReadLine());
                Console.Write("Digite o nome da agência: ");
                string nomeAgencia = Console.ReadLine();
                Console.Write("Digite o telefone da agência: ");
                string telefoneAgencia = Console.ReadLine();
                var agencia = new Agencia(numeroAgencia, nomeAgencia, telefoneAgencia);

                // Solicitar informações do cliente
                Console.Write("Digite o nome do cliente: ");
                string nomeCliente = Console.ReadLine();
                Console.Write("Digite o CPF do cliente: ");
                string cpfCliente = Console.ReadLine();
                var cliente = new Cliente(nomeCliente, cpfCliente);

                // Solicitar informações da conta
                Console.Write("Digite o número da conta: ");
                long numeroConta = long.Parse(Console.ReadLine());
                Console.Write("Digite o saldo inicial da conta: ");
                decimal saldoInicial = decimal.Parse(Console.ReadLine());
                var conta = new Conta(numeroConta, agencia, cliente, saldoInicial);

                // Exibir saldo inicial
                Console.WriteLine($"\nSaldo inicial da conta {conta.Numero}: {conta.Saldo:C}");

            string opcao;

            do
            {
                Console.WriteLine("\nEscolha uma operação:");
                Console.WriteLine("1 - Depósito");
                Console.WriteLine("2 - Saque");
                Console.WriteLine("3 - Sair");
                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o valor do depósito: ");
                        decimal valorDeposito = decimal.Parse(Console.ReadLine());
                        conta.Deposito(valorDeposito);
                        Console.WriteLine($"Saldo após depósito: {conta.Saldo}");
                        break;

                    case "2":
                        Console.Write("Digite o valor do saque: ");
                        decimal valorSaque = decimal.Parse(Console.ReadLine());
                        conta.Saque(valorSaque);
                        Console.WriteLine($"Saldo após saque: {conta.Saldo}");
                        break;

                    case "3":
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (opcao != "3");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
    
}