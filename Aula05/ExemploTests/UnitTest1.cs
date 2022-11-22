namespace ExemploTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveFazerAContabilizacaoComBaseNosDadosDoCliente()
        {
            ///AAA
            //Arrange => Preparacao
            //Act => Executar o método que vai ser testado
            //Assert => Verificacao


            Assert.AreEqual(1, 1);
        }


        [TestMethod]
        public void DeveFazerAContabilizacaoComBaseNosDadosDoClienteQuandoOclienteEhPessoaCanonica()
        {
            Assert.AreEqual(1, 0);
        }
    }
}