// Задача:
// Токарей = 3,
// 2 токаря - 1 разряда. Каждый из них делает по 1 детали
// 1 токарь 4 разряда. Токарь 4 разряда делат в два раза больше чем 2 токаря вместе.
// Вычислите, возможно ли такое?

using static System.Console;

Clear();

Write("Введите количество деталей: ");
int i = int.Parse(ReadLine()!);

int tokar_1r = 1;
int tokar_4r = 2 * (tokar_1r + tokar_1r);

int sum_proizvodstvo = tokar_1r + tokar_1r + tokar_4r;

if (i % sum_proizvodstvo == 0)
{
    WriteLine("Это правда");
    WriteLine($"Первое двое токарей 1-го разряда, сделали по {i / 6}");
    WriteLine($"Третий токарь 4-го разряда, сделал {i / 6 + 4}");
}
else
{
    WriteLine("Они лгут!");
}
