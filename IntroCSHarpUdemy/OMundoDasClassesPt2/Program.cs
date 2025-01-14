﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesPt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new Cachorro("Rex", 5);
            var g = new Gato("Ana", 4);

            Animal a = new Gato("Felix", 5); // Polimorfismo: o gato também é animal


            ExibeAnimal(c); //recebe argumento do tipo cachorro
            ExibeAnimal(g); //recebe argumento do tipo gato
            ExibeAnimal(a); //recebe argumento do tipo animal
        }

        public static void ExibeAnimal(Animal animal)
        {
            Console.WriteLine($"Nome: {animal.Nome}");
            Console.WriteLine($"Idade: {animal.Idade}");
            Console.WriteLine($"Som emitido: {animal.SomEmitido}");
            Console.WriteLine($"Locomocao: {animal.Locomocao}");
        }
    }
}
