using Classes;
using System.Linq.Expressions;

Console.WriteLine("Bem vindo ao programa, escolha uma função para ser executada: ");
bool prossiga = true;
do
{
    try
    {
        Console.WriteLine("0 - Sair");
        Console.WriteLine("1 - Soma de Números");
        Console.WriteLine("2 - Conversão de metros para milimetros");
        Console.WriteLine("3 - Verificação do Triângulo");
        int indice = int.Parse(Console.ReadLine());
        if (indice == 0)
        {
            prossiga = false;
        }
        else if (indice == 1)
        {
            Console.WriteLine("Agora você vai somar os números");
            Console.WriteLine("Entre com primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com segundo número: ");
            int b = int.Parse(Console.ReadLine());
            Calculadora calculadora = new Calculadora();
            Console.WriteLine($"O resultado da soma é: {calculadora.Soma(a, b)}\n");
        }
        else if (indice == 2)
        {
            Console.WriteLine("Agora você vai converter Metro para Milímetro");
            Console.WriteLine("Entre com a quantidade de metros a ser convertida: ");
            float metro = float.Parse(Console.ReadLine());
            Conversor conversor = new Conversor();
            Console.WriteLine($"O metro convertido é: {conversor.Converte_metro(metro)}\n");
        }
        else if (indice == 3)
        {
            Console.WriteLine("Agora você vai montar um triângulo equilátero");
            Console.WriteLine("Entre com a medida A: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a medida B: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a medida C: ");
            float c = float.Parse(Console.ReadLine());
            Verificacao verificacao = new Verificacao();
            Console.WriteLine($"{verificacao.Verifica_triangulo(a, b, c)}\n");
        }
        }
    catch (FormatException)
    {
        Console.WriteLine("Informe apenas os números citados... \n");
    }
    
} while (prossiga);
