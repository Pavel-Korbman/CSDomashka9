// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int start, int stop)
{
    if (start == stop) return start;
    else return start + SumNumbers(start + 1, stop);
}

Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber < 0 || secondNumber < 0)
{
    Console.WriteLine("Оба числа должны быть положительными");
}
else if (firstNumber < secondNumber)
{
    Console.WriteLine($"Cумма натуральных элементов: {SumNumbers(firstNumber, secondNumber)}");
}
else Console.WriteLine($"Cумма натуральных элементов: {SumNumbers(secondNumber, firstNumber)}");
