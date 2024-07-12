using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposEVariaaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 10; //declara uma variavel e armazena o valor 10 nela
            int numero2 = 20;
            var soma = numero1 + numero2; // o var define dinamicamente o tipo da variavel, poderia ser int
            Console.WriteLine("10 + 20 = " + soma);

            int copiaDeNumero1 = numero1; //copia o valor da variavel numero 1
            Console.WriteLine(copiaDeNumero1);
            copiaDeNumero1 = 11; // sera que o valor de numero 1 foi alterado
            Console.WriteLine(numero1);
            Console.WriteLine(copiaDeNumero1);

            var quadrado1 = new Quadrado();//cria um quadrado
            quadrado1.lado = 10;//quadrado1 tera 10 lado
            var quadrado2 = quadrado1;//sera que a copia do quadrado foi completa, ou se copia apenas a referencia
            //quadrado2.lado = 11;
            Console.WriteLine(quadrado1.lado);//quadrado1 deveria ter o lado igual a 10 
            Console.WriteLine(quadrado2.lado);//quadrado2 deveria ter o lado igual a 11

        }
        class Quadrado //define um classe chamada quadrado
        {
            public int lado; //define u atributo interno chamado lado, na classe Quadrado
        }
    }
}
