// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using static System.Console;
Clear();
Write("Введите число >1: ");
int number1 = int.Parse(ReadLine()!);
Write("Введите число >1: ");
int number2 = int.Parse(ReadLine()!);

WriteLine(GetSum(number1, number2));



double GetSum(int numberA, int numberB)
{
    if (numberA > numberB)
    {
        int temp = numberA;
        numberA = numberB;
        numberB = temp;
        
    }
 return (numberA == numberB) ? numberB : GetSum(numberA+1, numberB) + numberA;
}