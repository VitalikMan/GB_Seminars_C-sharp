// Рекурсия - метод который вызывает внутри, сам себя.
// Первое правило:
// Если задачу можно решить задачу без использования рекурсии,
// то лучше решить, не используя рекурсию.
// Второе правило:
// сразу определить, когда она закончится рекурсия.

// Задача:
// Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"

// N = 6 -> "1, 2, 3, 4, 5, 6"

using static System.Console;

Clear();

string result = GetNumbers(10);
WriteLine(result);


string GetNumbers(int num)
{
    if (num == 1) return num.ToString();
    else return $"{GetNumbers(num - 1)},{num}";
}


WriteLine(GetNumbers1(10));

string GetNumbers1(int num)
{
    return (num == 1) ? num.ToString() : $"{GetNumbers(num - 1)},{num}";
}


PrintNumbers(10);

void PrintNumbers(int num)
{
    if (num == 1) Write(num);
    else
    {
        PrintNumbers(num - 1);
        Write($",{num}");
    }
}
