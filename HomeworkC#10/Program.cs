// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] GetMatrix(int m, int n, double minV, double maxV)
// {
//     double[,] matrix = new double[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Math.Round(new Random().NextDouble() * 10, 2);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(double[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i, j] + "\t");
//         }

//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] result = GetMatrix(rows, columns, 0, 10);
// PrintMatrix(result);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// int[,] matrix = new int[3, 4];
// void GetMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// GetMatrix(matrix);

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// PrintMatrix(matrix);

// int rows = ReadInt("Введите позицию строки: ");
// int colums = ReadInt("Введите позицию столбца: ");
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// if (rows < matrix.GetLength(0) && colums < matrix.GetLength(1)) Console.WriteLine(matrix[rows, colums]);
// else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] matrix = new int[4, 4];
// void GetMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// GetMatrix(matrix);

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// PrintMatrix(matrix);

// void AveregeColomnsMatrix(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum += array[i, j];
//         }
//         Console.Write($"{sum / array.GetLength(0)} ; ");
//     }
// }
// AveregeColomnsMatrix(matrix);