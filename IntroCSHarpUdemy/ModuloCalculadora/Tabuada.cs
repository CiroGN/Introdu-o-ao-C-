using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCalculadora
{
    /// <summary>
    /// calcula a tabuada
    /// </summary>
    public class Tabuada
    {
        /// <summary>
        /// numero do qual sera calculada a tabuada
        /// </summary>
        public int Numero { get; }

        public Tabuada(int numero)
        {
            Numero = numero;
        }
        /// <summary>
        /// realiza o calculo da tabuada
        /// </summary>
        /// <param name="de">
        /// inicio do intervalo para calculo da tabuada
        /// </param>
        /// <param name="ate">
        /// final do intervalo para calculo da tabuada
        /// </param>
        /// <returns>
        /// tabuada do numero informado dentro do intervalo fornecido
        /// </returns>
        public string Calcular(int de, int ate)
        {
            var sb = new StringBuilder();
            for (int i = de; i <= ate; i++)
            {
                sb.AppendLine($"{Numero} x {i} = {OperacoesAritmeticas.Multiplicacao(Numero, i)}");
            }
            return sb.ToString();
        }
    }
}
