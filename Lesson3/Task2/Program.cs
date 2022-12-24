// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка

using static System.Console;

Clear();

Write("Введите кооринаты точки X: ");
int x = int.Parse(ReadLine()!);

Write("Введите кооринаты точки X: ");
int y = int.Parse(ReadLine()!);

if (x > 0 && y > 0)
{
    WriteLine("1 четверть");
}
if (x < 0 && y > 0)
{
    WriteLine("2 четверть");
}
if (x < 0 && y < 0)
{
    WriteLine("3 четверть");
}
if (x > 0 && y < 0)
{
    WriteLine("4 четверть");
}
