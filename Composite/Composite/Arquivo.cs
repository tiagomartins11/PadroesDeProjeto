using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Arquivo : ComponenteArquivo
    {
        private string _nome;
        public Arquivo(string nome)
        {
            _nome = nome;
        }

        public override void Exibir(int nivel)
        {
            Console.WriteLine(new string('-', nivel) + _nome);
        }
            
    }
}
