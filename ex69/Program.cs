// **Задача 69:** Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)

// A = 2; B = 3 -> 8

using static System.Console;
Clear();
Write("Введите положительное целое число A: ");
int number1 = int.Parse(ReadLine()!);
Write("Введите положительное целое число B: ");
int number2 = int.Parse(ReadLine()!);
WriteLine(GetPow(number1,number2));



double GetPow(int number, int power)
{
return(power==0)? 1:GetPow(number, power-1)*number;
}
