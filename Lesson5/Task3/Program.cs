/*
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/

using static System.Console;
Clear();

Write("Введи число: ");
int number = int.Parse(ReadLine()!);

int[] array = GetArray(10, 0, 5);

bool isInArray = check_number_in_array(number, array);
printArray(array, number, isInArray);

int[] GetArray(int size, int minValue, int maxValue)
{

    int[] resultArray = new int[size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = random.Next(minValue, maxValue + 1);
    }

    return resultArray;
}

bool check_number_in_array(int number, int[] array)
{
    bool result = false;
    foreach (int i in array)
    {
        if (number == i) result = true;
    }

    return result;
}

void printArray(int[] array, int number, bool flag)
{
    if (flag) Write($"Число {number} присутствует в массиве: ");
    else Write($"Число {number} отсутствует в массиве: ");
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]}, ");
    }

    WriteLine($"{array[array.Length - 1]}]");
}
