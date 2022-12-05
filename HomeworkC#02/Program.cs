// Задача 2: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;
if (secondNumber > max)
{
    Console.WriteLine(max = secondNumber);
}
else Console.WriteLine(max = firstNumber);
if (thirdNumber > max)
{
    Console.WriteLine(max = thirdNumber);
}
else Console.WriteLine(max);
Console.WriteLine("max = " + max);