namespace Modelos;

class Baralho
{
    List<Carta> Cartas;

    public Baralho()
    {
        var rand = new Random();
        var baralho = new List<Carta>();

        for (int i = 1; i <= 100; i++) // Valor padrão
        {
            if (rand.NextDouble() < 0.3)
            {
                int multiplicador = rand.Next(2, 5);
                baralho.Add(new CartaComMultiplicador(i, multiplicador));
            }
            else
            {
                baralho.Add(new Carta(i));
            }
        }

        Cartas = baralho;
    }


    public Baralho(int tamanho)
    {
        var baralho = new List<Carta>();

        for (int i = 1; i <= tamanho; i++)
        {
            baralho.Add(new Carta(i));
        }
        Cartas = baralho;
    }

    public Carta DarCarta()
    {
        int posicaoPrimeiraCarta = 0;
        Carta carta = Cartas[posicaoPrimeiraCarta];
        Cartas.RemoveAt(posicaoPrimeiraCarta);
        return carta;
    }

    public void Embaralhar()
    {
        var rand = new Random();
        Cartas = Cartas.OrderBy(x => rand.Next()).ToList();
    }

}