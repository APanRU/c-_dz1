﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.Write("Введите число ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA % 2 == 0)
{
    Console.Write("Введенное число четное");
}

else
{
    Console.Write("Введенное число не является четным");
}

