using Classes;
namespace Testes
{
    [TestClass]
    public class Teste_Verificacao
    {
        [TestMethod]
        public void TesteVerificacao()
        {
            //Cen�rio
            float a = 2;
            float b = 2;
            float c = 2;

            Verificacao verificacao= new Verificacao();
            //A��o
            string resultado = verificacao.Verifica_triangulo(a, b, c);
            //Verifica��o
            Assert.AreEqual("Esse tri�ngulo � equil�tero", resultado);

        }
    }
}