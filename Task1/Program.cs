﻿// Задача 64:
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string PrintNumbers(int start)
{
if (start == 1) return start.ToString();
else return start+" "+ PrintNumbers(start-1);
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32 (Console.ReadLine());
if (number<=0) Console.WriteLine("Число должно быть положительным");
else Console.WriteLine(PrintNumbers(number));