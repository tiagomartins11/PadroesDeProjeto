
using System;
namespace Facade
{
    class Program
    {
        static void Main()
        {
            var maquina = new MaquinaCafeFacade();
            maquina.FazerCafe();
        }
    }

}

