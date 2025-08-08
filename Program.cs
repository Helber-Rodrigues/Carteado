namespace Carteado
{
    using Modelos;

    class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();
            jogo.Jogar();

            Console.ReadLine();

            // jogo.VerificarGanhador(); é inacessível porque é private
        }
    }
}