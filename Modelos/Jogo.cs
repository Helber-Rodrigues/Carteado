namespace Modelos;

class Jogo
{
    Baralho Baralho;
    Jogador Jogador1;
    Jogador Jogador2;

    public Jogo()
    {
        Baralho = new Baralho();
        Jogador1 = new Jogador();
        Jogador2 = new Jogador();
    }

    public Jogo(Baralho baralho)
    {
        Baralho = baralho;
        Jogador1 = new Jogador();
        Jogador2 = new Jogador();
    }

    public Jogo(Baralho baralho, Jogador jogador1, Jogador jogador2)
    {
        Baralho = baralho;
        Jogador1 = jogador1;
        Jogador2 = jogador2;
    }

    public void Jogar()
    {
        Baralho.Embaralhar();
        Jogador1.Carta = Baralho.DarCarta();
        Jogador2.Carta = Baralho.DarCarta();

        VerificarGanhador();
    }

    private void VerificarGanhador()
    {
        int pontuacao1 = Jogador1.Carta.Pontuacao();
        int pontuacao2 = Jogador2.Carta.Pontuacao();

        if (pontuacao1 > pontuacao2)
        {
            Console.WriteLine($"Jogador 1 ganhou! Pontuação: {pontuacao1} vs {pontuacao2}");
        }
        else if (pontuacao2 > pontuacao1)
        {
            Console.WriteLine($"Jogador 2 ganhou! Pontuação: {pontuacao1} vs {pontuacao2}");
        }
        else
        {
            Console.WriteLine($"Empate! Pontuação: {pontuacao1} vs {pontuacao2}");
        }

        // Exibe informações detalhadas das cartas
        MostrarCarta("Jogador 1", Jogador1.Carta);
        MostrarCarta("Jogador 2", Jogador2.Carta);
    }

    private void MostrarCarta(string nomeJogador, Carta carta)
    {
        if (carta is CartaComMultiplicador cm)
        {
            Console.WriteLine($"{nomeJogador}: Carta {cm.Valor} x{cm.Multiplicador} = {cm.Pontuacao()} pontos");
        }
        else
        {
            Console.WriteLine($"{nomeJogador}: Carta {carta.Valor} = {carta.Pontuacao()} pontos");
        }
    }

}