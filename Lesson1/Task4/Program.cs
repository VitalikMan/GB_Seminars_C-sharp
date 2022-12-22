using static System.Console;

Write("Введите число: ");
int num = Convert.ToInt32(ReadLine()!);

int last_num = num % 10;

Write($"Последняя цифра числа {num}: {last_num}");
