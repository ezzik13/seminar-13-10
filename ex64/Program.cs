// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;
Clear();
Write("Введите число >1: ");
int number1 = int.Parse(ReadLine()!);

string numbersStr = GetNumbers(number1);
WriteLine(numbersStr);


string GetNumbers(int n)
{
    return (n == 1)? n.ToString():  n+" "+GetNumbers(n -1);
}