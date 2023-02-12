// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12

// 45 -> 9

using static System.Console;

Clear();

Write("Введите число: ");
string str_number = ReadLine()!;

WriteLine(SumNumbers(int.Parse(str_number)));

int SumNumbers(int num)
{
    if (num == 0) return num;
    else return SumNumbers(num / 10) + num % 10;
}
