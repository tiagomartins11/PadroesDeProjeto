using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class MensagemComItalico : MensagemDecorator
    {
        public MensagemComItalico(Mensagem mensagem) : base(mensagem) { }

        public override string ObterTexto()
        {
            return$"<i>{_mensagem.ObterTexto()}</i>";
        }   
            
    }
}
