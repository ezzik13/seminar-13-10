// **Задача 63:** Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"

// N = 6 -> "1, 2, 3, 4, 5, 6"

using static System.Console;
Clear();
Write("Введите число >1: ");
int number = int.Parse(ReadLine()!);
string numbersStr = GetNumbers(number);
WriteLine(numbersStr);
GetNumbers1(number);
WriteLine();
string numbersStr2 = GetNumbers2(number);
WriteLine(numbersStr2);

string GetNumbers(int n)
{
    if (n == 1) return n.ToString();
    return GetNumbers(n - 1) + " " + n;
}
void GetNumbers1(int n)
{
    if (n == 1) Write(n);
    else
    {
        GetNumbers1(n - 1);
        Write(" " + n);
    }
}
string GetNumbers2(int n)
{
    return (n == 1)? n.ToString(): GetNumbers(n - 1) + " " + n;
}