using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class MensagemSimples : Mensagem
    {
        public override string ObterTexto() => "Olá Professor";
    }
}
