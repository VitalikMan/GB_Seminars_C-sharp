// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

using static System.Console;

Clear();

Write("Введите длину сторону а: ");
int a = int.Parse(ReadLine()!);
Write("Введите длину сторону b: ");
int b = int.Parse(ReadLine()!);
Write("Введите длину сторону c: ");
int c = int.Parse(ReadLine()!);

WriteLine(Triangle(a, b, c));

string Triangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a)
    {
        return $"Треугольник со сторонами {a}, {b}, {c} может существовать";
    }
    else
    {
        return $"Треугольник со сторонами {a}, {b}, {c} не может существовать";
    }
}
