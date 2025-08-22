namespace Modelos
{
    class Jogador
    {
        public string Nome { get; private set; }
        public Carta? Carta { get; set; }
        public int Pontos { get; private set; }

        public Jogador(string nome)
        {
            Nome = nome;
            Pontos = 0; // Garante que o jogador sempre comece com 0 pontos.
        }

        public void AdicionarPonto()
        {
            Pontos++;
        }
    }
}