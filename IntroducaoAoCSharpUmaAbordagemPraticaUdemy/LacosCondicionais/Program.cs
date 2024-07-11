using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LacosCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lacos condicionais => execucao mediante determinada condicao/situacao satisfeita
            int hora = 18;
            //laco if
            if(hora <= 15)// se a hora for maior ou igual a 15, sera impressa a mensagem no console
            {
                Console.WriteLine("Sao menos que 15 horas");
            }
            /*nao precisa de escopo
            if (hora >= 15 || hora == 13)
                Console.WriteLine("A hora é maior ou igual a 15 OU é igual a 13");
            */
            //laco else if
            else if (hora <= 17)
                Console.WriteLine("a hora é menor que 17");
            //else //garante a execucao do bloco de codigo seguinte a ele 
                //Console.WriteLine("ja passou das 17, hora atual " + hora);
            //laco else
            else
            {
                if (hora == 18)
                    Console.WriteLine("sao 18h");
                else
                    Console.WriteLine("nao sao 18 horas");
            }
            //laco switch
            //geralmente a expressao avaliada é uma constante 
            switch (hora)
            {
                case 15:
                    Console.WriteLine("Sao 15 horas");
                    break;
                case 18:
                    Console.WriteLine("Sao 18 horas");
                    break;
            }

            PrimeiroSemestre mes = PrimeiroSemestre.Maio;
            switch (mes)
            {
                case PrimeiroSemestre.Janeiro:
                    Console.WriteLine("Estamos em Janeiro");
                    break;
                case PrimeiroSemestre.Fevereiro:
                    Console.WriteLine("Estamos em Fevereiro");
                    break;
                case PrimeiroSemestre.Marco:
                    Console.WriteLine("Estamos em Marco");
                    break;
                default:
                    Console.WriteLine("O mes atual nao é nem Janeiro nem Fevereiro, nem Marco é: " + mes);
                    break;
            }
            //lacos aninhados
            //A cada iteração em i temos 3 iterações em j, as quais imprimem sempre 0, 1 e 2.
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Console.WriteLine("j = "+j);
                }
                Console.WriteLine("i = "+i);
            }
        }
    }
    public enum PrimeiroSemestre
    {
        Janeiro, Fevereiro, Marco, Abril, Maio, Junho
    }
}
