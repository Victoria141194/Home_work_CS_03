Console.Write("Введите целое число: ");
string userInput1 = Console.ReadLine() ?? "";
int N = int.Parse(userInput1);

Console.Write($"{N} -> ");
PrintCubes(N);

////////////////////////////////////////////////////

void PrintCubes(int N)
{
    for (int i = 1; i < N; i++)
    {
       Console.Write($"{i*i*i}, ");
    }
    Console.Write($"{N*N*N}");
}