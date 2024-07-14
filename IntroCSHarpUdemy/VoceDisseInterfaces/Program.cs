using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoceDisseInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = new ImpressoraComum();
            var i2 = new ImpressoraCopiadora();
            
            Console.WriteLine(i.Imprimir("Estou aprendendo C#"));
            Console.WriteLine(i2.Copiar("Estou aprendendo C# e estou gostando"));

            CopiarDocumento(new Xerox(), "Hello World");
        }

        public static void CopiarDocumento(ICopiadora c, string texto)
        {
            Console.WriteLine("Estou copiando o texto a seguir: " + c.Copiar(texto));
        }
    }
}
