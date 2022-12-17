// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }
// int[] resultArray = GetArray(4, 100, 1000);
// int evenNum = 0;
// for (int i = 0; i < resultArray.Length; i++)
// {
//     if (resultArray[i] % 2 == 0) evenNum++;
// }
// Console.Write($"Array: [{String.Join(", ", resultArray)}]");
// Console.Write($" -> {String.Join(" ", evenNum)}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-100, 100);
//     }
//     return array;
// }
// int[] resultArray = GetArray(4, -100, 100);
// int sum = 0;
// for (int i = 0; i < resultArray.Length; i++)
// {
//     sum = resultArray[1] + resultArray[3];
// }
// Console.Write($"Array: [{String.Join(", ", resultArray)}]");
// Console.Write($" -> {String.Join(" ", sum)}");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


// double[] GetArray(int size, double minValue, double maxValue)
// {
//     double[] array = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 100);
//     }
//     return array;
// }
// double[] resultArray = GetArray(6, 0, 100);
// double min = resultArray[0];
// double max = resultArray[0];
// for (int i = 0; i < resultArray.Length; i++)
// {
//     if (resultArray[i] > max) max = resultArray[i];
//     if (resultArray[i] < min) min = resultArray[i];
// }
// double diff = max - min;
// Console.Write($"Array: [{String.Join(", ", resultArray)}]");
// Console.Write($" -> {String.Join(" ", diff)}");
