namespace Carteado
{
    using Modelos;

    class Program
    {
        static void Main(string[] args)
        {
            // A criação das cartas com multiplicador é mais interessante para o jogo!
            List<Carta> CriarCartasComMultiplicador()
            {
                List<Carta> cartas = new List<Carta>();
                // Reduzindo o número de cartas para um jogo mais rápido
                for (int i = 1; i <= 13; i++) // Ex: Do Ás (1) ao Rei (13)
                {
                    for (int j = 1; j <= 4; j++) // 4 naipes/multiplicadores
                    {
                        cartas.Add(new CartaComMultiplicador(i, j));
                    }
                }
                return cartas;
            }

            Baralho baralho = new Baralho(CriarCartasComMultiplicador());

            // Instancia o jogo com os nomes dos jogadores e o número de rodadas
            Jogo jogo = new Jogo(baralho, "Jogador 1", "Jogador 2", 5);
            jogo.Jogar();
            Console.WriteLine("Fim");
            Console.ReadLine();
        }
    }
}