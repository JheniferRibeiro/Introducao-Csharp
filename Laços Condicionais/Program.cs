// See https://aka.ms/new-console-template for more information
using System.Drawing;

Console.WriteLine("Hello, World!");

//{
    //Laços Condicionais => execução mediante determinada condição/situação satisfeita
    int hora = 18;


    ////Laço if, else if e else

    if (hora <= 15) //Se a hora for menor ou igual a 15, a linha será impressa a imagem no console
        Console.WriteLine("São menos que 15h!");

    else if (hora <= 17)
        Console.WriteLine("A hora é menor ou igual a 17!");
    else // o else garante a execução do bloco de código seguinte a ele

    {
        if (hora == 18)
            Console.WriteLine("São 18h!");
        else
           Console.WriteLine("Já passou das 18h!");
    }
     //swith... case
     //geralmente a expressão avaliada é constante
     //em nenhuma hipótese serão executados dois casos 
    switch (hora)
{ // o teste condicional é exato
        case 15: 
           Console.WriteLine("São 15h!");
            break;
        case 18: 
           Console.WriteLine("São 18h!");
            break;
    }

    PrimeiroSemestre mes = PrimeiroSemestre.Fevereiro;
    switch (mes)
    {

        case PrimeiroSemestre.Janeiro:
        Console.WriteLine("Estamos em Janeiro!");
            break;
        case PrimeiroSemestre.Fevereiro:
        Console.WriteLine("Estamos em Feveiro!");
            break;
        case PrimeiroSemestre.Marco:
        Console.WriteLine("Estamos em Marco!");
            break;
        case PrimeiroSemestre.Abril:
        Console.WriteLine("Estamos em Abril!");
            break;
        case PrimeiroSemestre.Maio:
        Console.WriteLine("Estamos em Maio!");
            break;
        case PrimeiroSemestre.Junho:
        Console.WriteLine("Estamos em Junho!");
            break;
    default: // Ele será executado se nenhum dos outros foi satisfeito!
        Console.WriteLine("O mes atual não é nem Janeiro, Fevereiro ou Março! É " + mes);
            break;
    }

public enum PrimeiroSemestre
{
    Janeiro, Fevereiro, Marco, Abril, Maio, Junho
}

