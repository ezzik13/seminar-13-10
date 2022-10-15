// **Задача 65:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"
using static System.Console;
Clear();
Write("Введите число >1: ");
int number1 = int.Parse(ReadLine()!);
Write("Введите число >1: ");
int number2 = int.Parse(ReadLine()!);

string numbersStr = GetNumbers(number1, number2);
WriteLine(numbersStr);


string GetNumbers(int m, int n)
{
    if(n<m)
    return (n == m)? n.ToString(): GetNumbers(n + 1, m) + " " + n; // от большего к меньшему
    else
    return (n == m)? m.ToString(): GetNumbers(m + 1, n) + " " + m;

    // if(n>m)
    // return (n == m)? n.ToString(): GetNumbers(n - 1, m) + " " + n; // от меньшего к большему
    // else
    // return (n == m)? m.ToString(): GetNumbers(m - 1, n) + " " + m;
}