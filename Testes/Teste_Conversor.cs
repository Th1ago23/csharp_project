using Classes;
namespace Testes
{
    [TestClass]
    public class Teste_Conversor
    {
        [TestMethod]
        public void TesteConversor()
        {
            //Cen�rio
            float metro = 2;

            Conversor conversor = new Conversor();
            //A��o
            float resultado = conversor.Converte_metro(metro);
            //Verifica��o
            Assert.AreEqual(2000, resultado);

        }
    }
}