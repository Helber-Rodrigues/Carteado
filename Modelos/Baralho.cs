namespace Modelos;

class Baralho
{
    public List<Carta> Cartas { get; private set; }

    [Obsolete("Use Baralho(list<Carta>) constructor instead.")]
    public Baralho()
    {
        var baralho = new List<Carta>();

        for (int i = 1; i <= 100; i++)
        {
            baralho.Add(new Carta(i)); // Está estranho o baralho ter que saber demais sobre a Carta
        }
        Cartas = baralho;
    }

    public Baralho(List<Carta> cartas)
    {
        Cartas = cartas;
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