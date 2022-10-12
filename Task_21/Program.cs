int x1, y1, z1, x2, y2, z2;

x1 = Coordinates("Введите координату X первого числа: ");
y1 = Coordinates("Введите координату Y первого числа: ");
z1 = Coordinates("Введите координату Z первого числа: ");
x2 = Coordinates("Введите координату Х второго числа: ");
y2 = Coordinates("Введите координату Y второго числа: ");
z2 = Coordinates("Введите координату Z второго числа: ");

double distance = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(distance);

/////////////////////////////////////////////////////////////////

int Coordinates(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}


double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}
