// Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 8 4 2 4

// 5 9 2 3

// 1 4 7 2

using static System.Console;

Clear();

Write("Введите через пробел размерность матрицы и мин и макс значения: ");
string[] par = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] matrixArray = GetMatrixArray(int.Parse(par[0]), int.Parse(par[1]), int.Parse(par[2]), int.Parse(par[3]));

int[,] GetMatrixArray(int rows, int columns, int inMinValue, int inMaxValue)
{
    Random rand = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rand.Next(inMinValue, inMaxValue + 1);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],4} ");
        }
        WriteLine();
    }
}

WriteLine("Полученный массив:");
PrintMatrixArray(matrixArray);

void NewMatrix(int[,] inArray)
{
    int temp = 0;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        temp = inArray[0, i];
        inArray[0, i] = inArray[inArray.GetLength(0) - 1, i];
        inArray[inArray.GetLength(0) - 1, i] = temp;
    }
}

WriteLine("Измененный массив:");
NewMatrix(matrixArray);
PrintMatrixArray(matrixArray);
