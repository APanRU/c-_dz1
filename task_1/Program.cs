//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.Write("Введите первое число ");
string x = Console.ReadLine();
int numberA = int.Parse(x);
Console.Write("Введите второе число ");
string y = Console.ReadLine();
int numberB = int.Parse(y);
if(numberA > numberB)
{
    Console.WriteLine("Первое число больше второго!");   
}
if(numberA == numberB)
{
    Console.WriteLine("Числа равны!");   
}
else
{
    Console.WriteLine("Второе число больше первого!");
}


