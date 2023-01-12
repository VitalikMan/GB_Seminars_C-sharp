// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4  -> 24
// 5  -> 120

// Доп.условие: при условии, что N будет делиться на это число без остатка.


using static System.Console;

Clear();

WriteLine("Введите число: ");
int num = int.Parse(ReadLine()!);

int SumNum = GetSumNum(num);
WriteLine($"Произведение ряда чисел от 1 до {num} = {SumNum}");

int GetSumNum(int num)
{
    int result = 1;
    while (num > 0)
    {
        result *= num;
        num--;
    }

    return result;
}
