Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber < 0 || secondNumber < 0) Console.WriteLine
("Оба числа должны быть неотрицательными.");
 else Console.WriteLine
 ($"А({firstNumber}, {secondNumber})= {AckermanFunction(firstNumber, secondNumber)}");

