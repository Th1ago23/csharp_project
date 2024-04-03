using Classes;
namespace Testes
{
    [TestClass]
    public class Teste_Verificacao_Equilatero_NaoEquilatero
    {
        [TestMethod]
        public void TesteVerificacaoNaoEquilatero()
        {
            //Cenário
            float a = 1;
            float b = 1;
            float c = 2;

            Verificacao verificacao_ne = new Verificacao();
            //Ação
            string resultado = verificacao_ne.Verifica_triangulo(a, b, c);
            //Verificação
            Assert.AreEqual("Esse triângulo não é equilátero", resultado);

        }
    }
}