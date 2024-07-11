using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuestoesConcurso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Question 1:
(VUNESP - 2018 - Prefeitura de Registro -SP - Técnico em Informática) Analise o trecho de código C# a seguir.*/

            int a = 10;
            int b = 5;
            int c = a + b * b + b;
            Console.WriteLine(c + "\n");
            //Ao final da execução desse código, a variável “c” terá o valor:

            /*Question 2:
(FGV - 2018 - CM Caruaru - Analista Legislativo - Informática) Analise o código C# .NET a seguir.*/

            for (int i = -5; i <= 7; i += 3)
            {
                Console.WriteLine(i);
            }
        
            //Assinale a opção que apresenta corretamente o resultado produzido pela execução do trecho acima.

            /*Question 3:
(UEL/COPS - 2013 - SANEPAR - Analista de Informática - Desenvolvedor em C#) Considere o trecho de código em linguagem de programação C# a seguir:*/
            int myInt = 0;
            while (myInt < 10)
            {
                Console.Write("{0} ", myInt);
            }
            Console.WriteLine();
        }
    }
        //Assinale a alternativa que apresenta, corretamente, o que o trecho de código em linguagem de programação C# fará ao ser executado.
}

