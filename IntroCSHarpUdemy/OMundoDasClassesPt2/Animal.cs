using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesPt2
{
    public abstract class Animal // uma classe abstrrata nao pode ser instanciada 
    {
        public string Nome { get; }
        public int Idade { get; }
        public abstract Som SomEmitido { get; }// essa propriedade deve ser implementada por cada classe filha, ja que é abstrata
        public virtual string Locomocao { get { return "Esta andando"; } } //essa propriedade poderá ou nao ser sobreescrita nas classes filhas

        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
