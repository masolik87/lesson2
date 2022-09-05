// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 100 && number < 1000)
{
    int secondDigit = (number % 100) / 10;
    Console.WriteLine($"Second digit {secondDigit}");
}
else Console.WriteLine("enter the correct number");
