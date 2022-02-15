using System;
using tabuleiro;
using xadrez;

namespace XadresDois
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {


                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimeTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.Write("Digite a Posicão: ");
                    Posicao origem = Tela.lerPosicaoXadres().toPosicao();
                    Console.Write("Digite a Destino: ");
                    Posicao destino = Tela.lerPosicaoXadres().toPosicao();
                    partida.ExecutaMovimento(origem, destino);
                }
                              
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}
