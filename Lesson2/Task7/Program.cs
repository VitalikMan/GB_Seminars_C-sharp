// Два стрелка
// На вход подаются один говорит 5 банок,
// второй говорит 10 банок.
// Один стрелок стреляет с одного конца, второй с другого.
// Сходятся они на одной банке и одновременно попадают в нее.
// Вывести общее количество банок

using static System.Console;

Clear();

Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

int result = a + b - 1;
WriteLine(result);
