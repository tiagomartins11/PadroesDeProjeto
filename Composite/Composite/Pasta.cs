using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Pasta : ComponenteArquivo
    {
        private string _nome;
        private List<ComponenteArquivo> _filhos = new();

        public Pasta(string nome)
        { 
            _nome = nome;
        }

        public void Adicionar(ComponenteArquivo filho)
        {
            _filhos.Add(filho);
        }

        public override void Exibir(int nivel)
        {
            Console.WriteLine(new string('-', nivel) + $"[Pasta] {_nome}");
            foreach (var filho in _filhos)
            {
                filho.Exibir(nivel + 2);
            }
        }
    }
}
