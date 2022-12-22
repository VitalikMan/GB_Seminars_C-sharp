using static System.Console;

Clear();

int number = new Random().Next(10, 100);

WriteLine(number);

//version 1:

WriteLine(number / 10 > number % 10 ? number / 10 : number % 10);

//version 2:

// if (number / 10 > number % 10)
// {
//     WriteLine(number / 10);
// }
// else
// {
//     WriteLine(number % 10);
// }
