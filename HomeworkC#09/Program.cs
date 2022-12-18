// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue);
//     }
//     return array;
// }
// int[] resultArray = GetArray(5, -100, 100);
// int finish = 0;
// for (int i = 0; i < resultArray.Length; i++)
// {
//     if (resultArray[i] > 0) finish++;
// }
// Console.Write($"Числа: {String.Join(", ", resultArray)}");
// Console.Write($" -> {String.Join(" ", finish)}");


// Задача 42: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("b1 = ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("k1 = ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("b2 = ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("k2 = ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// double x = -(b1 - b2) / (k1 - k2);;
// double y = k1 * x + b1;
// x = Math.Round(x, 2);
// y = Math.Round(y, 2);
// Console.Write($"Ответ: ({x};{y})");



