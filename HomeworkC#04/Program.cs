// Задача 4: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int firstNumber = 2;
int secondNumber = Convert.ToInt32(Console.ReadLine());
while (firstNumber <= secondNumber)
{
    Console.Write (firstNumber + ",");
    firstNumber += 2;
}