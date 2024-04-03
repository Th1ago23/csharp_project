using Classes;
namespace Testes
{
    [TestClass]
    public class Teste_Conversor
    {
        [TestMethod]
        public void TesteConversor()
        {
            //Cenário
            float metro = 2;

            Conversor conversor = new Conversor();
            //Ação
            float resultado = conversor.Converte_metro(metro);
            //Verificação
            Assert.AreEqual(2000, resultado);

        }
    }
}