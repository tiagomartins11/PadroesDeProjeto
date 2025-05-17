using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class MensagemComNegrito : MensagemDecorator
    {
        public MensagemComNegrito(Mensagem mensagem) : base(mensagem) { }

        public override string ObterTexto()
        {
            return $"<n>{_mensagem.ObterTexto()}</n>";
        }
    }
}
