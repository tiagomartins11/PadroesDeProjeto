using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class MaquinaCafeFacade
    {
        private Moedor moedor = new Moedor();
        private Aquecedor aquecedor = new Aquecedor();
        private Cafeteira cafeteira = new Cafeteira();


        public void FazerCafe()
        {
            moedor.MoerGraos();
            aquecedor.AquecerAgua();
            cafeteira.PrepararCafe();
        }
    }
}
