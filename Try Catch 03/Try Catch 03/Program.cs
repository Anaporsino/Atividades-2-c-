using System.Globalization;

try
{
    Console.Write("Digite o primeiro número: ");
    double n1;
    //! é = diferente
    {
        while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out n1))
            Console.WriteLine("Digite um número válido: ");
        
    }

    {
        Console.Write("\nDigite o segundo número: ");
        double n2;
        while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out n2))
            Console.WriteLine("Digite um número válido: ");
        

        if (n2 == 0)
        {
            throw new DivideByZeroException();
        }

        double soma = n1 + n2;
        Console.WriteLine($"\nA soma dos números é: {soma}");
    }
}
catch (DivideByZeroException)

{
    Console.WriteLine("\nErro: Não foi possível somar esses números");
}
//catch (FormatException)
//{
//    Console.WriteLine("\nPorfavor digite números válidos");
//}

Console.ReadKey();
