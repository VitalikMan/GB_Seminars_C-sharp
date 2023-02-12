// // Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// // В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// // Например, задан массив:

// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7

// // В итоге получается вот такой массив:

// // 1 5 8 5
// // 4 9 4 2
// // 7 2 2 6
// // 2 3 4 7

using static System.Console;

Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));

PrintMatrixArray(array);
WriteLine();

NewMatrix(array);
// PrintMatrixArray(array);

int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)

{
    Random rand = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rand.Next(minValue, maxValue);
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
            Write($"{inArray[i, j],3} ");  // вывод в 3 символа
        }
        WriteLine();
    }
}

void NewMatrix(int[,] inArray)
{
    int[,] result = new int[inArray.GetLength(0), inArray.GetLength(1)];

    if (inArray.GetLength(0) != inArray.GetLength(1))
    {

        WriteLine("Невозможно");

    }

    else
    {

        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                result[j, i] = inArray[i, j];
            }
        }
        PrintMatrixArray(result);


    }
}
