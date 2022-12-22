using static System.Console;

Write("Введите первое число: ");
int a = Convert.ToInt32(ReadLine()!);

Write("Введите второе число: ");
int b = Convert.ToInt32(ReadLine()!);

if (a == b * b)
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");
}
