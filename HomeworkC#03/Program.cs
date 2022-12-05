// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number % 2 == 1) Console.Write(Number + " - Число нечетное");
else Console.Write(Number + " - Число четное");