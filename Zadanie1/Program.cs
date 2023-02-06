// See https://aka.ms/new-console-template for more information

Console.Write("Введите трехзначное число:");
int num = int.Parse(Console.ReadLine());
int num1 = num / 10;
int result = num1 % 10;
Console.WriteLine($"{result}");