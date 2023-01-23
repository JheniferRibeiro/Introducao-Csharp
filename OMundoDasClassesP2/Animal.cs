using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesP2
{
    public abstract class Animal // Uma classe abstrata não pode ser instanciada
    {
        public string Nome { get; }
        public int Idade { get; }
        public abstract Som SomEmitido { get; } // Essa classe terá de ser implementada por cada classe filha, já que é abstrata 
        public virtual string Locomocao { get { return "Está andando"; } } //Essa prorpiedade poderá ou não ser subscrita nas classes filhas


        public Animal(string nome, int idade) 
        {
            Nome = nome;
            Idade = idade; 
        } 

    }
}
