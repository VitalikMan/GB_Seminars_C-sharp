// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)

// A = 2; B = 3 -> 8

using static System.Console;

Clear();

Write("Введите значения: число и степень через пробел: ");
string[] str_arg = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine(Numbers(int.Parse(str_arg[0]), int.Parse(str_arg[1])));

int Numbers(int a, int b)
{
    if (b == a) return a;
    else return Numbers(a, b - 1) * a;
}
