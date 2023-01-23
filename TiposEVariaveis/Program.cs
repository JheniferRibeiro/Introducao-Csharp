// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World. My name is Jhenifer. I'm 19 years old.");


{ 
    int numero1 = 10; // declara uma variavel inteira e armazena o valor 10 nela
    int numero2 = 20; 
    var soma = numero1 + numero2; // o var determina dinamicamente o tipo de variavel 
    Console.WriteLine("10 + 20 = " + soma);

    int copiaDeNumero1 = numero1; // copia o valor da variavel 'numero1'
    copiaDeNumero1 = 11;
    Console.WriteLine(numero1);
    Console.WriteLine(copiaDeNumero1);

    var quadrado1 = new Quadrado(); // cria um quadrado
    quadrado1.lado = 10; // quadrado1 terá valor de lado igual a 10
    var quadrado2 = quadrado1; // será?
    quadrado2.lado = 11;
    Console.WriteLine(quadrado1.lado); // quadrado1 deveria ter o lado = 10
    Console.WriteLine(quadrado2.lado); // quadrado2 deveria ter o lado = 11



}

class Quadrado // define uma classe chamada quadrado

{
    public int lado; // Define um atributo inteiro chamado lado, na classe Quadrado


}