namespace Modelos
{
    class Carta
    {
        public int Valor;

        public Carta(int valor)
        {
            Valor = valor;
        }

        public virtual int Pontuacao()
        {
            return Valor;
        }
    }

    class CartaComMultiplicador : Carta
    {
        public int Multiplicador { get; private set; }

        public CartaComMultiplicador(int valor, int multiplicador) : base(valor)
        {
            Multiplicador = multiplicador;
        }

        public override int Pontuacao()
        {
            return Valor * Multiplicador;
        }
    }
}
