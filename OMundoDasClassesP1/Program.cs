using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OMundoDasClassesP1
{
    class Program // Sem modificador de acesso explicíto = internal por padrão 
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(Cor.Branco, 4, "Gol G6"); // criando carro

            // Exibindo atributos do carro
            Console.WriteLine("O carro é um " + carro.Modelo + " de cor " + carro.Cor + " e tem " + carro.Portas + " portas.");


            Console.WriteLine(carro.Ligar()); // Ligar carro
            Console.WriteLine("Ligado? " + carro.Ligado );
            Console.WriteLine(carro.Andar()); // Andar com carro
            Console.WriteLine(carro.Desligar()); // Desligar o carro 
            Console.WriteLine("Ligado? " + carro.Ligado);

            carro.Cor = Cor.Azul; // Pintando a cor do carro
            Console.WriteLine("A nova cor do carro é " + carro.Cor);
        }
    }
}