using Projeto.DataModel;

namespace Projeto.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveriaValidarSeOObjetoPessoaFoiCriadoCorretamente()
        {
            //Arrange
            var pessoa = new Pessoa
            {
                Nome = "1"
            };

            //Act


            //Assert
            Assert.IsNotNull(pessoa);
            Assert.AreEqual(pessoa.GetType(), typeof(Pessoa));
            Assert.AreEqual("1", pessoa.Nome);
        }
    }
}