﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей 
//цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("enter the number: ");
string? number = Console.ReadLine();

if (number?.Length > 2)
{
  Console.WriteLine($"Third digit " + number[2]);
}
else
{
  Console.WriteLine("Третьей цифры нет");
}
