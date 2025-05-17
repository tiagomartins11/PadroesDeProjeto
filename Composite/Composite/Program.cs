using System.IO;

namespace Composite
{
    class Program
    {
        static void Main()
        {
            var raiz = new Pasta("Raiz");
            raiz.Adicionar(new Arquivo("arquivo1.txt"));

            var subPasta = new Pasta("Documentos");
            subPasta.Adicionar(new Arquivo("doc1.pdf"));
            subPasta.Adicionar(new Arquivo("doc2.pdf"));

            raiz.Adicionar(subPasta);
            raiz.Exibir(0);
        }
    }

}