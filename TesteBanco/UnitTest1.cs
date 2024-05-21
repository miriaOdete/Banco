using static System.Net.Mime.MediaTypeNames;
using Banco;

namespace TesteBanco
{
    [TestClass]
    public class AgenciaTests
    {
        [TestMethod]
        public void CriarAgencia_ComNumeroValido_DeveCriarAgencia()
        {
            // Arrange & Act
            var agencia = new Agencia(123, "Agencia Centro", "1234-5678");

            // Assert
            Assert.AreEqual(123, agencia.Numero);
            Assert.AreEqual("Agencia Centro", agencia.Nome);
            Assert.AreEqual("1234-5678", agencia.Telefone);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CriarAgencia_SemNumero_DeveLancarExcecao()
        {
            // Arrange, Act & Assert
            var agencia = new Agencia(0, "Agencia Centro", "1234-5678");
        }
    }

    [TestClass]
    public class ClienteTests
    {
        [TestMethod]
        public void ValidarDados()
        {
            // Arrange & Act
            var cliente = new Cliente("João da Silva", "123.456.789-00");

            // Assert
            Assert.AreEqual("João da Silva", cliente.Nome);
            Assert.AreEqual("123.456.789-00", cliente.Cpf);
            
        }

        
    }

    [TestClass]
    public class ContaTests
    {
        [TestMethod]
        public void CriarConta_ComAgenciaEClienteValidos_DeveCriarConta()
        {
            // Arrange
            var agencia = new Agencia(123, "Agencia Centro", "1234-5678");
            var cliente = new Cliente("João da Silva", "123.456.789-00");

            // Act
            var conta = new Conta(456, agencia, cliente);

            // Assert
            Assert.AreEqual(456, conta.Numero);
            Assert.AreEqual(agencia, conta.Agencia);
            Assert.AreEqual(cliente, conta.Cliente);
        }

       
}