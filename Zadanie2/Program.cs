// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите любое число: ");
int a = Int32.Parse(Console.ReadLine());
if(a <= 99){
    Console.WriteLine("Число меньше 100");
}else{
    while(a > 1000){
        a /=10; 

    }
        Console.WriteLine(a%10);
}
