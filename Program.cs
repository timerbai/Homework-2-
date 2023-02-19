// Домашняя работа
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// void Metod(int num)
// {
//     int dec = (num / 10) % 10;
//     Console.WriteLine(dec);
// }
// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Metod(num2);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// void WeekNumber (int num)
// {
//     if (num < 6)
//     {
//      Console.WriteLine("Нет");
//     }
// else 
// {
//     Console.WriteLine("Да");
// }
// }
// Console.WriteLine("Введите число дня недели");
// int num = Convert.ToInt32(Console.ReadLine());
// WeekNumber(num);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// void Chislo (int num)
// {
// if (num > 100)
// {
// int dec = (num / 100) % 10;
// Console.WriteLine(dec);
// }
// else 
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// }
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// Chislo(num);