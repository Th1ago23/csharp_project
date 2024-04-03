using Classes;
namespace Testes
{
    [TestClass]
    public class Teste_Calculadora
    {
        [TestMethod]
        public void TesteSoma()
        {
            //Cenário
            int a = 1;
            int b = 2;

            Calculadora calculadora = new Calculadora();
            //Ação
            int resultado = calculadora.Soma(a, b);
            //Verificação
            Assert.AreEqual(3, resultado);

        }
    }
}