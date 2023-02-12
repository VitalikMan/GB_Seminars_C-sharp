// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

using static System.Console;

Clear();

// // Вариант Марии:

// int M = 2;
// int N = 10;

// WriteLine(GetNumbers(M, N));

// string GetNumbers(int numberOne, int numberTwo)
// {
//     if (numberOne == numberTwo) return numberTwo.ToString();
//     else return $"{GetNumbers(numberOne + 1, numberTwo)},{numberOne}";
// }


// Вариант Рената:

Write("Введите значения M и N через пробел: ");
string[] str_arg = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

Write($"M = {str_arg[0]}; N = {str_arg[1]}. -> ");
int M = int.Parse(str_arg[0]);
int N = int.Parse(str_arg[1]);

PrintNumbers(M, N);
WriteLine();


void PrintNumbers(int m, int n)
{
    if (m < n)
    {
        int temp = m;
        m = n;
        n = temp;
    }
    if (m == n) Write(n);
    else
    {

        PrintNumbers(m - 1, n);
        Write($",{m}");
    }
}
