namespace Modelos;

class Jogo
{
    private Baralho Baralho { get; set; }
    private Jogador Jogador1 { get; set; }
    private Jogador Jogador2 { get; set; }
    private int NumeroDeRodadas { get; set; }

    public Jogo(Baralho baralho, string nomeJogador1, string nomeJogador2, int numeroDeRodadas = 5)
    {
        Baralho = baralho;
        Jogador1 = new Jogador(nomeJogador1);
        Jogador2 = new Jogador(nomeJogador2);
        NumeroDeRodadas = numeroDeRodadas;
    }

    public void Jogar()
    {
        Baralho.Embaralhar();

        for (int i = 0; i < NumeroDeRodadas; i++)
        {
            Console.WriteLine($"\n--- Rodada {i + 1} ---");
            JogarRodada();
        }

        VerificarGanhadorFinal();
    }

    private void JogarRodada()
    {
        // Verifica se há cartas suficientes para a rodada
        if (Baralho.Cartas.Count < 2)
        {
            Console.WriteLine("Não há cartas suficientes no baralho para continuar.");
            // Força o fim do loop no método Jogar()
            NumeroDeRodadas = 0;
            return;
        }

        Jogador1.Carta = Baralho.DarCarta();
        Jogador2.Carta = Baralho.DarCarta();

        Console.WriteLine($"{Jogador1.Nome} tirou a carta com pontuação: {Jogador1.Carta.Pontuacao()}");
        Console.WriteLine($"{Jogador2.Nome} tirou a carta com pontuação: {Jogador2.Carta.Pontuacao()}");

        if (Jogador1.Carta.Pontuacao() > Jogador2.Carta.Pontuacao())
        {
            Jogador1.AdicionarPonto();
            Console.WriteLine($"Ponto para {Jogador1.Nome}!");
        }
        else if (Jogador2.Carta.Pontuacao() > Jogador1.Carta.Pontuacao())
        {
            Jogador2.AdicionarPonto();
            Console.WriteLine($"Ponto para {Jogador2.Nome}!");
        }
        else
        {
            Console.WriteLine("Empate na rodada!");
        }
    }

    private void VerificarGanhadorFinal()
    {
        Console.WriteLine("\n--- Fim de Jogo ---");
        Console.WriteLine($"Placar Final: {Jogador1.Nome} {Jogador1.Pontos} x {Jogador2.Pontos} {Jogador2.Nome}");

        if (Jogador1.Pontos > Jogador2.Pontos)
        {
            Console.WriteLine($"O grande vencedor é {Jogador1.Nome}!");
        }
        else if (Jogador2.Pontos > Jogador1.Pontos)
        {
            Console.WriteLine($"O grande vencedor é {Jogador2.Nome}!");
        }
        else
        {
            Console.WriteLine("O jogo terminou em empate!");
        }
    }
}