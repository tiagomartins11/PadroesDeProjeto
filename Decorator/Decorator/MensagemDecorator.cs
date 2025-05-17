using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class MensagemDecorator : Mensagem
    {
        protected Mensagem _mensagem;
        public MensagemDecorator(Mensagem mensagem)
        {
            _mensagem = mensagem;
        }
            
    }
}
