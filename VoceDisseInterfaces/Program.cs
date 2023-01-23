using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoceDisseInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = new ImpressoraComum();
            var i2 = new ImpressoraCopiadora();
            var i3 = new ImpressoraCopiadora();
            var i4 = new ImpressoraEscaneadora();
            Console.WriteLine(i.Imprimir("Estou estudando C#"));
            Console.WriteLine(i2.Copiar("Estou estudando C# e estou gostando"));
            Console.WriteLine(i4.Escanear("Estou estudando C# e escaneando"));

            CopiarDocumento(new Xerox(), "Hello, World!");

        }

        public static void CopiarDocumento(ICopiadora copiadora, string texto)
        {
            Console.WriteLine("Estou copiando o texto a seguir: " + copiadora.Copiar(texto));
        }
    }
}