using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesP2
{
    class Program
    {
        static void Main(string[] args)
        { 
            var c = new Cachorro("Rex", 5);
            var g = new Gato("Ana", 3);

            Animal a = new Gato("Felix", 5); // Polimorfismo: O gato também é um animal !

            ExibeAnimal(c); // recebe o argumento do tipo cachorro
            ExibeAnimal(g); // recebe o argumento do tipo gato
            ExibeAnimal(a); // recebe argumento do tipo animal

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