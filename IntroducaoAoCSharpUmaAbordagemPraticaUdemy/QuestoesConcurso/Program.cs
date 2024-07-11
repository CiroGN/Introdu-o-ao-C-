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

                    /*Question 4:
(FGV - 2018 - BANESTES - Analista em Tecnologia da Informação -Suporte e Infraestrutura) Analise os trechos de código C# exibidos a seguir.*/
            for (int i = 0; i < 10; i++)
            {
                if ((i % 2) == 0)
                {
                    break;
                }
                xpto1(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if ((i % 2) == 0)
                {
                    continue;
                }
                xpto2(i);
            }
            /*Dado que o operador % resulta no resto da divisão de seus operandos, está correto concluir que xpto1 e xpto2 serão invocados:

Dica 1: a palavra-chave break invocada dentro de um laço iterativo causa sua interrupção imediata, ou seja, após ser chamada a próxima linha de código a ser executada é aquela imediatamente após laço.

Dica 2: a palavra-chave continue invocada dentro de um laço iterativo causa o salto imediato para a próxima iteração.*/
}

