
using System.Diagnostics.Contracts;

namespace Modelos;

class Carta
{
    private int Valor;

    public Carta(int valor)
    {
        Valor = valor;
    }

    virtual public int Pontuacao()
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

    override public int Pontuacao()
    {
        return base.Pontuacao() * Multiplicador;
    }
}
