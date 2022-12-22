// вводится 2 числа с клавиатуры
// Вывести в ответ только знак:
// 5 и 7 -> <
// 5 и 8 -> >
// 8 и 8 -> =

using static System.Console;

Clear();

Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

// version 1:

// if (a < b)
// {
//     WriteLine("<");
// }
// else if (a > b)
// {
//     WriteLine(">");
// }
// else
// {
//     WriteLine("=");
// }

// version 2:

WriteLine(a < b ? "<" : a > b ? ">" : "=");
