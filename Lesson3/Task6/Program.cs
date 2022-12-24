// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.

using static System.Console;

Clear();

WriteLine("Введите координаты первой точки: ");
int ax = int.Parse(ReadLine()!);
int ay = int.Parse(ReadLine()!);

WriteLine("Введите координаты второй точки: ");
int bx = int.Parse(ReadLine()!);
int by = int.Parse(ReadLine()!);

int x = ax - bx;
int y = ay - bx;

double result = Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2)));

WriteLine($"Длина отрезка {result:f2}");
