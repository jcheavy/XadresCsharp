using System;
using tabuleiro;
namespace XadresDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new Posicao(4, 4);
            Console.WriteLine("Linha :"+ p.Linha);
            Console.WriteLine("Coluna :" + p.Coluna);

            Tabuleiro tab = new Tabuleiro(9, 9);
        }
    }
}
