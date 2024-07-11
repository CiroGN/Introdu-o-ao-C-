using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//pasta logica
namespace HelloWorld
{
    internal class Program
    {
        //Isso é um comentario de uma linha! Tudo que for escrito é ignorado
        //pelo compilador 

        /*Este 
        é
        um
        comentario
        de
        mais
        de
        uma
        linha
        */

        //metodo main:
        //ponto de entrada para a aplicação, ou seja, é
        //o que define o inicio de aplicacao
        static void Main(string[] args)
        {
            string nome = "Ciro";
            //imprimir na tela o famoso "Olá mundo"
            Console.WriteLine("Olá, Mundo!");
            Console.WriteLine("Meu nome é " + nome);
        }
    }
}
