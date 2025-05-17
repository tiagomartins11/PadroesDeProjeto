namespace Decorator
{
    class Program
    {
        static void Main()
        {
            Mensagem simples = new MensagemSimples();
            Mensagem negrito = new MensagemComNegrito(new MensagemSimples());
            Mensagem italico = new MensagemComItalico(new MensagemSimples());

            Console.WriteLine(simples.ObterTexto());
            Console.WriteLine(negrito.ObterTexto());
            Console.WriteLine(italico.ObterTexto());
        }
    }
}
