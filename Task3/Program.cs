// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if (n == 0) return AckermanFunction(m - 1, 1);
        else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }
}

Console.WriteLine("Введите первый аргумент:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй аргумент:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber < 0 || secondNumber < 0) Console.WriteLine
("Оба числа должны быть неотрицательными.");
else Console.WriteLine
($"А({firstNumber},{secondNumber}) = {AckermanFunction(firstNumber, secondNumber)}");