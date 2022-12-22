// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.

using static System.Console;

Write("Введите число: ");
int num = int.Parse(ReadLine()!);
int moduleNum = -num;

while (num >= moduleNum)
{
    WriteLine(moduleNum);
    moduleNum += 1;
}
