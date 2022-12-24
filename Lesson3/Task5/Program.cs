using static System.Console;

Clear();

Write("Введите номер дня недели: ");

bool isParse = int.TryParse(ReadLine(), out int i);

if (!isParse)
{
    WriteLine("Введено не число!");
    return;
}

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
