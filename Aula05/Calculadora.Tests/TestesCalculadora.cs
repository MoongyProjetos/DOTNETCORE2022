namespace Calculadora.Tests
{
    [TestClass]
    public class TestesCalculadora
    {
        /// <summary>
        /// Validar se sou capaz de somar 0 e 0 sem problema
        /// </summary>
        [TestMethod] //Shoudly 
        public void DeveriaSerCapazDeSomarZeroEZero()
        {
            //Arrange
            var A = 0;
            var B = 0;
            var maquinaDeCalcular = new Calculadora();

            //Act
            var resultado = maquinaDeCalcular.Somar(A, B);

            //Assert
            Assert.AreEqual(0, resultado);
        }


        [TestMethod] //Shoudly 
        public void DeveriaSerCapazDeSomarValorNegativoComValorNegativo()
        {
            //Arrange
            var A = -1;
            var B = -1;
            var maquinaDeCalcular = new Calculadora();

            //Act
            var resultado = maquinaDeCalcular.Somar(A, B);

            //Assert
            Assert.AreEqual(-2, resultado);
        }


        [TestMethod] //Shoudly 
        public void DeveriaSerCapazDeSomarValorNegativoComValorPositivo()
        {
            //Arrange
            var A = 1;
            var B = -1;
            var maquinaDeCalcular = new Calculadora();

            //Act
            var resultado = maquinaDeCalcular.Somar(A, B);

            //Assert
            Assert.AreEqual(0, resultado);
        }



        [TestMethod] //Shoudly 
        public void DeveriaSerCapazDeSomarValorPositivoComValorNegativo()
        {
            //Arrange
            var A = -1;
            var B = 1;
            var maquinaDeCalcular = new Calculadora();

            //Act
            var resultado = maquinaDeCalcular.Somar(A, B);

            //Assert
            Assert.AreEqual(0, resultado);
        }


         [TestMethod] //Shoudly 
        public void DeveriaSerCapazDeSomarValorPositivoComValorPositivo()
        {
            //Arrange
            var A = 1;
            var B = 1;
            var maquinaDeCalcular = new Calculadora();

            //Act
            var resultado = maquinaDeCalcular.Somar(A, B);

            //Assert
            Assert.AreEqual(2, resultado);
        }
    }
}