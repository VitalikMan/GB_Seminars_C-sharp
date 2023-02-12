// Tom Marvolo Riddle => I am Lord Voldemort
// Можно ли с одной строки собрать вторую?

// Вариант на семинаре: (не правильный!)

// using static System.Console;

// Clear();

// Write("Введите первую строку: ");
// string str1 = ReadLine()!;

// Write("Введите вторую строку: ");
// string str2 = ReadLine()!;

// WriteLine(CheckMagic(str1, str2));

// bool CheckMagic(string One, string Two)
// {
//     One = One.ToLower();
//     foreach (char c in One)
//     {
//         return !(Two.Contains(c));
//     }
//     return true;
// }



// Вариант от Марии: (не проверял! Не знаю.. но вроде как работает)

using static System.Console;
using static System.Array;

Clear();

Write("Введите первую строку: ");
string str1 = ReadLine()!;

Write("Введите вторую строку: ");
string str2 = ReadLine()!;


CheckMagic(str1, str2);

void CheckMagic(string One, string Two)
{
    One = One.ToLower();
    Two = Two.ToLower();

    char[] charOne = One.ToCharArray();
    char[] charTwo = Two.ToCharArray();

    Array.Sort(charOne);
    Array.Sort(charTwo);

    bool result = Enumerable.SequenceEqual(charOne, charTwo);

    WriteLine(result);
}
