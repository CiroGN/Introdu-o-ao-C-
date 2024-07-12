using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LacosIterativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lacos iterativos => estruturas que repetem um bloco de codigo, determinado numero de vezes

            //laco for
            for(int i = 0; i<5; i++)//i++ significa que i sera incrementado de 1 em 1
            {
                Console.WriteLine("Valor de i é " + i);
            }

            //while
            int contador = 3;
            while(contador < 10)
            {
                Console.WriteLine("Valor de contador é " + contador);
                contador++;
            }

            //do while
            //execucao garantida pelo menos uma vez! (executa o bloco primeiro e depois faz teste de condicao)
            double j = 10;
            do
            {
                Console.WriteLine(j);
                j = j * 1.5;
            } while (j < 100);

            //foreach
            //percorre todos os elementos de um conjunto
            int[] conjunto = { 1, 2, 5, 6 };
            foreach(int numero in conjunto)
            {
                Console.WriteLine("Esse elemento do conjunto tem valor " + numero + "! Somando esse numero a 10 temos " + (numero + 10));
            }
        }
    }
}
