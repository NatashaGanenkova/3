// See https://aka.ms/new-console-template for more information
Console.Write("Введите номер дня недели:");
int num = int.Parse(Console.ReadLine());
if(num>=1&& num<=5)
{
    Console.Write("Нет");
}
else if(num==6||num==7)
{
    Console.Write("Да");
}   
else
{
    Console.Write("Не существует такого дня недели");
}  
