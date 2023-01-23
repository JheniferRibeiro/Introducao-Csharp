using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoceDisseInterfaces
{
    public class ImpressoraMultifuncional : IImpressora, ICopiadora, IEscaneadora
    {
        public string Copiar(string texto)
        {
            return texto;
        }

        public string Escanear(string texto)
        {
            return texto;
        }

        public string Imprimir(string texto)
        {
            return texto;
        }
    }
}
