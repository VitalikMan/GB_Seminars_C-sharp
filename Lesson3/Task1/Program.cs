// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

using static System.Console;

Clear();

Write("Введите номер четверти двумерной координатной плоскости: ");
int i = int.Parse(ReadLine()!);

if (i < 1 || i > 4)
{
    WriteLine("Ошибка");
}
if (i == 1)
{
    WriteLine("x>0 y>0");
}
if (i == 2)
{
    WriteLine("x<0 y>0");
}
if (i == 3)
{
    WriteLine("x<0 y<0");
}
if (i == 4)
{
    WriteLine("x>0 y>0");
}
