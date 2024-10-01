Console.Write("Escolha um número 1-12: ");
int numMes = int.Parse(Console.ReadLine());

switch (numMes)
{
    case 1:
        Console.WriteLine($"Janeiro, e a estação é Verão");
        break;


    case 2:
        Console.WriteLine($"Fevereiro, e a estação é Verão");
        break;


    case 3:
        Console.WriteLine($"Março, e a estação é Outono");
        break;


    case 4:
        Console.WriteLine($"Abril, e a estação é Outono");
        break;


    case 5:
        Console.WriteLine($"Maio, e a estação é Outono");
        break;


    case 6:
        Console.WriteLine($"Junho, e a estação é Inverno");
        break;


    case 7:
        Console.WriteLine($"Julho, e a estação é Inverno");
        break;


    case 8:
        Console.WriteLine($"Agosto, e a estação é Inverno");
        break;


    case 9:
        Console.WriteLine($"Setembro, e a estação é Primavera");
        break;


    case 10:
        Console.WriteLine($"Outubro, e a estação é Primavera");
        break;


    case 11:
        Console.WriteLine($"Novembro, e a estação é Primavera");
        break;


    case 12:
        Console.WriteLine($"Dezembro, e a estação é Verão");
        break;


    default:
        Console.WriteLine("O número escolhido não é permitido");
        Console.WriteLine("Escolha um número 1-12");
        break;
}

Console.WriteLine("Clique uma tecla para encerrar");
Console.ReadKey();