// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3

// 78 -> 2

// 89126 -> 5

using static System.Console;

Clear();

WriteLine("Введите число: ");
int num = int.Parse(ReadLine()!);

int SumNum = GetSumNum(num);
WriteLine($"Количество цифр в числе в {num} = {SumNum}");

int GetSumNum(int num)
{
    int result = 0;
    while (num > 0)
    {
        result++;
        num /= 10;
    }

    return result;
}
