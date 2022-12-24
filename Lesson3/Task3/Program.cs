// Написать программу, на вход которой подается число соответствующая дню недели,
// выведите имя дня недели.

using static System.Console;
Clear();

Write("Введи день недели:");

int i = int.Parse(ReadLine()!);

switch (i)
{
    case 1:
        {
            WriteLine("Понедельник");
            break;
        }
    case 2:
        {
            WriteLine("Вторник");
            break;
        }
    case 3:
        {
            WriteLine("Среда");
            break;
        }
    case 4:
        {
            WriteLine("Четверг");
            break;
        }
    case 5:
        {
            WriteLine("Пятница");
            break;
        }
    case 6:
        {
            WriteLine("Субботу");
            break;
        }
    case 7:
        {
            WriteLine("Воскресенье");
            break;
        }
    default:
        {
            WriteLine("Нет такого дня недели");
            break;
        }
}
