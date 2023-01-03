// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine()); 
// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString(); 
//     return (start + ", " + PrintNumbers(start - 1, end));
// } 
// Console.WriteLine($"N = {n} -> {PrintNumbers(n,1)}"); 


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.Write("Введите значение M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int M, int N)
// {
//     if (M == 0) return (N * (N + 1)) / 2;
//     else if (N == 0) return (M * (M + 1)) / 2;
//     else if (M == N) return M;
//     else if (M < N) return N + SumNumbers(M, N - 1);
//     else return N + SumNumbers(M, N + 1);
// }
// Console.Write($"M = {M}; N = {N} -> {SumNumbers(M, N)}");



