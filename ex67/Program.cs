// **Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12

// 45 -> 9

using static System.Console;
Clear();
Write("Введите число >1: ");
int number1 = int.Parse(ReadLine()!);
int sum = SumDigits(number1);

WriteLine($"Сумма цифр числа {number1} равна {sum}");




int SumDigits(int number)
{
    return (number / 10 == 0) ? number  : SumDigits(number / 10) + number % 10;
}