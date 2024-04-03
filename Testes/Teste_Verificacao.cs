using Classes;
namespace Testes
{
    [TestClass]
    public class Teste_Verificacao
    {
        [TestMethod]
        public void TesteVerificacao()
        {
            //Cenário
            float a = 2;
            float b = 2;
            float c = 2;

            Verificacao verificacao= new Verificacao();
            //Ação
            string resultado = verificacao.Verifica_triangulo(a, b, c);
            //Verificação
            Assert.AreEqual("Esse triângulo é equilátero", resultado);

        }
    }
}