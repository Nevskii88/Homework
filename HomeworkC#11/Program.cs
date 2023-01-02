// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int rows = 3;
// int columns = 4;

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// void MaxElementRows(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//             {
//                 if (matrix[i, k] < matrix[i, k + 1])
//                 {
//                     int temp = matrix [i, k + 1];
//                     matrix[i, k + 1] = matrix[i, k];
//                     matrix[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// int[,] result = GetArray(rows, columns, 0, 10);
// Console.WriteLine("Исходный массив: ");
// PrintArray(result);
// MaxElementRows(result);
// Console.WriteLine("Окончательный массив: ");
// PrintArray(result);


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int rows = 3;
// int columns = 4;

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// void MinSumElementRows(int[,] matrix)
// {
//     int index = 0, minsum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[i, j];
//         }
//         if (i == 0) minsum = sum;
//         else if (sum < minsum)
//         {
//             minsum = sum;
//             index = i;
//         }
//     }
//     Console.WriteLine($"Строка с минимальной суммой элементов: {index + 1} ");
// }

// int[,] result = GetArray(rows, columns, 0, 10);
// PrintArray(result);
// MinSumElementRows(result);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] firstMatrix = new int[2, 2];
// GetArray(firstMatrix);
// Console.WriteLine("Первая матрица:");
// PrintArray(firstMatrix);

// int[,] secondMatrix = new int[2, 2];
// GetArray(secondMatrix);
// Console.WriteLine("Вторая матрица:");
// PrintArray(secondMatrix);

// int[,] resultMatrix = new int[2, 2];

// void GetArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// void MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
// {
//     for (int i = 0; i < resultMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < resultMatrix.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < firstMatrix.GetLength(1); k++)
//             {
//                 sum = firstMatrix[i, j] * secondMatrix[i, j];
//             }
//             resultMatrix[i, j] = sum;
//         }
//     }
// }

// MultiplicationMatrix(firstMatrix, secondMatrix, resultMatrix);
// Console.WriteLine("Произведение первой и второй матриц:");
// PrintArray(resultMatrix);


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// int[,,] Array = new int[2, 2, 2];
// GetArray(Array);
// PrintArray(Array);

// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} = ({i},{j},{k}); ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// void GetArray(int[,,] array)
// {
//     int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
//     int number;
//     for (int i = 0; i < temp.GetLength(0); i++)
//     {
//         temp[i] = new Random().Next(10, 100);
//         number = temp[i];
//         if (i >= 1)
//         {
//             for (int j = 0; j < i; j++)
//             {
//                 while (temp[i] == temp[j])
//                 {
//                     temp[i] = new Random().Next(10, 100);
//                     j = 0;
//                     number = temp[i];
//                 }
//                 number = temp[i];
//             }
//         }
//     }

//     int count = 0;
//     for (int x = 0; x < array.GetLength(0); x++)
//     {
//         for (int y = 0; y < array.GetLength(1); y++)
//         {
//             for (int z = 0; z < array.GetLength(2); z++)
//             {
//                 array[x, y, z] = temp[count];
//                 count++;
//             }
//         }
//     }
// }