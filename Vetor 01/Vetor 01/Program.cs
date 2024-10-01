
string[] weekday = new string[] {

    "Segunda",
    "Terça",
    "Quarta ",
    "Quinta",
    "Sexta",
    "Sabado",
    "Domingo" };

string[] tarefa = new string[7];

for (int i = 0; i < weekday.Length; i++)
{
    Console.Write($"Digite suas tarefas para: {weekday[i]}: ");
    tarefa[i] = Console.ReadLine();
}

Console.WriteLine("\nTarefas da semana:");
for (int i = 0; i < weekday.Length; i++)
{

    Console.WriteLine($"{weekday[i]}: {tarefa[i]}");

}

Console.ReadKey();
