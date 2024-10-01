int n1;

Console.WriteLine("Informe sua nota de 0 a 100: ");
int.TryParse(Console.ReadLine(), out n1);

if (n1 >= 90 && n1 <= 100)
    Console.WriteLine($"\n A nota foi de {n1} então é um A :) ");

else if (n1 >= 80 && n1 <= 89)
    Console.WriteLine($"\n A nota foi de {n1} então é um B !!! ");

else if (n1 >= 70 && n1 <= 79)
    Console.WriteLine($"\n A nota foi de {n1} então é um C !! ");

else if (n1 >= 60 && n1 <= 69)
    Console.WriteLine($"\n A nota foi de {n1} então é um D ! ");

else
    Console.WriteLine($"\n A nota foi de {n1} então é um F :( ");

Console.ReadKey();