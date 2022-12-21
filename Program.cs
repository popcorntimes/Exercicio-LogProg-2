using System;
namespace Exercicio_LogProg_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a porcentagem: ");
            decimal porcentagem = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o total negociado: ");
            int totalNegociado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(funcaoRetornaQuantidadePOV(porcentagem, totalNegociado));
        }
    }
}