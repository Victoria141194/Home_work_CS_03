Console.Write("Введите пятизначное число: ");
string userInput1 = Console.ReadLine() ?? "";
int num = int.Parse(userInput1);

int a5 = num % 10;
int a4 = (num / 10) % 10;
int num1 = num / 1000;
int a2 = num1 % 10;
int a1 = num1 / 10;

if (a1 == a5 && a2 == a4)
    Console.Write ($"{num} -> число является палиндромом");
else Console.Write ($"{num} -> число не является палиндромом");