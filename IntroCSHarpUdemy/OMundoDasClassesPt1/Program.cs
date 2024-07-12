using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesPt1
{
    internal class Program //sem modificador de acesso explicito = internal padrao
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(Cor.Branco, 4, "Gol G6"); // criando carro
            Console.WriteLine("O carro é um " + carro.Modelo + " de cor " + carro.Cor + " e tem " + carro.Portas + " portas");

            //carro.Ligado = false; nao ocorre pois so se pode acessar o estado de uma variavel private bool
            //e nao definir por causa da propriedade criada em Carro qu permite apenas leitura

            Console.WriteLine(carro.Ligar());//ligar carro
            Console.WriteLine("Ligado " + carro.Ligado);
            Console.WriteLine(carro.Andar());//andar com carro
            Console.WriteLine(carro.Desligar());
            Console.WriteLine("Ligado " + carro.Ligado);

            carro.Cor = Cor.Azul; //Pintando o carro de azul
            Console.WriteLine("A nova cor do carro é " + carro.Cor);
        }
    }
}
