namespace Modelos
{
    class Jogador
    {
        public Carta Carta { get; set; }

        public Jogador()
        {
            Carta = new Carta(0); // Valor padrão
        }
    }
}