using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCalculadora
{
    /// <summary>
    /// Classe com operacoes matematicas basicas de adicao, subtracao, multiplicacao e adicao 
    /// </summary>
    public static class OperacoesAritmeticas // uma classe estatica: nao pode ser instanciada, nao pode herdar e nem ser herdada, so pode conter membros estaticos  
    {
        /// <summary>
        /// operacao basica de adicao
        /// </summary>
        /// <param name="parcela1">
        /// a primeira parcela
        /// </param>
        /// <param name="parcela2">
        /// a segunda parcela
        /// </param>
        /// <returns>
        /// a soma das parcelas
        /// </returns>
        public static double Adicao(double parcela1, double parcela2)
        {
            return parcela1 + parcela2;
        }
        /// <summary>
        /// operacao basica de subtracao
        /// </summary>
        /// <param name="minuando">
        /// o minuando da operacao
        /// </param>
        /// <param name="subtraendo">
        /// o subtraendo da operacao
        /// </param>
        /// <returns>
        /// a subtracao entre os valores
        /// </returns>
        public static double Subtracao(double minuando, double subtraendo)
        {
            return minuando - subtraendo;
        }
        /// <summary>
        /// operacao basica de multiplicacao
        /// </summary>
        /// <param name="multiplicando">
        /// o multiplicando
        /// </param>
        /// <param name="multiplicador">
        /// o multiplicador
        /// </param>
        /// <returns>
        /// a multiplicacao dos valores
        /// </returns>
        public static double Multiplicacao(double multiplicando, double multiplicador)
        {
            return multiplicando * multiplicador;
        }
        /// <summary>
        /// operacao basica de divisao
        /// </summary>
        /// <param name="dividendo">
        /// o dividendo
        /// </param>
        /// <param name="divisor">
        /// o divisor
        /// </param>
        /// <returns>
        /// a divisao dos valores
        /// </returns>
        public static double Divisao(double dividendo, double divisor)
        {
            return dividendo / divisor;
        }
    }
}
