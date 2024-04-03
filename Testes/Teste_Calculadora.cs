using Classes;
namespace Testes
{
    [TestClass]
    public class Teste_Calculadora
    {
        [TestMethod]
        public void TesteSoma()
        {
            //Cen�rio
            int a = 1;
            int b = 2;

            Calculadora calculadora = new Calculadora();
            //A��o
            int resultado = calculadora.Soma(a, b);
            //Verifica��o
            Assert.AreEqual(3, resultado);

        }
    }
}