// Напишите программу, которая будет создавать копию заданного
// массива с помощью поэлементного копирования.

using static System.Console;

Clear();

Write("Ведите размер массива: ");
int arraySize = int.Parse(ReadLine()!);
int[] array = GetArray(arraySize);
WriteLine(String.Join(", ", array));

int[] array2 = CopyArray(array);
WriteLine(String.Join(", ", array2));

int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().Next(1, 10);
    }
    return resultArray;
}

int[] CopyArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[i];
    }
    return result;
}
