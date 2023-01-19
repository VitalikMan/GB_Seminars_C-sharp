// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

using static System.Console;
Clear();

WriteLine("Введите число: ");
int num = int.Parse(ReadLine()!);
WriteLine($"Число в двоичной системе счисления: {ConvertTo2(num)}");

string ConvertTo2(int number)
{
    if (number == 0) return "0";
    string result = string.Empty;
    while (number > 0)
    {
        result = number % 2 + result;
        number /= 2;
    }
    return result;
}
