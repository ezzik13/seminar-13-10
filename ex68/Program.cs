// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


using static System.Console;
Clear();
Write("Введите число >1: ");
int number1 = int.Parse(ReadLine()!);
Write("Введите число >1: ");
int number2 = int.Parse(ReadLine()!);
WriteLine(GetAkkerman(number1, number2));

int GetAkkerman(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    else
    if (b == 0 && a > 0)
    {
        return GetAkkerman(a - 1, 1);
    }
    else
    {
        return (GetAkkerman(a - 1, GetAkkerman(a, b - 1)));
    }
}