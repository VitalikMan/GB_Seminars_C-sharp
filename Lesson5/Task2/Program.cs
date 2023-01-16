/*
Напишите программу замена элементов массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
*/

using static System.Console;
Clear();

int[] array = GetArray(10, -10, 10);
WriteLine("Массив до изменений");
printArray(array);
ChangeArray(array);
WriteLine("Массив после изменений");
printArray(array);

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

void printArray(int[] array)
{
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]}, ");
    }

    WriteLine($"{array[array.Length - 1]}]");
}

void ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}
