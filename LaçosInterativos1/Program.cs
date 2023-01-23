// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello");

{
    //Laços Interativos => estruturas que repetem um bloco de códigos, determinado um número de vezes

    //Laço for

    for (int i = 0; i < 5; i++) // i++ significa que i  será incrementado de 1 em 1
    {
        Console.WriteLine("Valor de i é " + i);
    }

    //While
    int contador = 3;
    while (contador < 10)
    {
        Console.WriteLine(contador);
        contador++;
    }
    // Do ... while
    //Excecução garantida pelo menos uma vez!(executa o bloco primeiro e depois teste de condição)
    double j = 10;
    do
    {
        Console.WriteLine(j);
        j = j * 1.5;
    } while (j < 100);

    //Foreach
    // Percorre todos os elementos de um conjunto
    int[] conjunto = { 1, 2, 3, 4 };
    foreach(int numero in conjunto)
    {
        Console.WriteLine("Esse elemento do conjunto tem valor " + numero + "! Somando esse valor a 10 temos " + (numero +10));
    }
}