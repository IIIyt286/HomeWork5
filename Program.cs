// // Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.Write("Введите количество строк в массиве - ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов в массиве - ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] arr = new int[rows, columns];
// FillArr(arr);
// Console.WriteLine("Введите номер строки элемента массива - ");
// int elR = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца элемента массива - ");
// int elC = Convert.ToInt32(Console.ReadLine());
// if (elR >= 0 && elR < rows)
// {
//     if (elC >= 0 && elC < columns)
//     {
//         Console.WriteLine($"Указанный элемент массива = {arr[elR, elC]}");
//     }
//     else
// {
//     Console.WriteLine("Указанного элемента в массиве нет");
// }

// }
// else
// {
//     Console.WriteLine("Указанного элемента в массиве нет");
// }

// void FillArr(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//             Console.Write($"|{array[i, j]}|");
//         }
//         Console.WriteLine();
//     }
// }





// // Задача 2: Задайте двумерный массив. 
// //Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Console.Write("Введите количество строк в массиве - ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов в массиве - ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int[rows, columns];
// FillArr(arr);
// Console.WriteLine();
// retArr(arr);

// void FillArr(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//             Console.Write($"|{array[i, j]}|");
//         }
//         Console.WriteLine();
//     }
// }

// void retArr(int[,] array)
// {
//     int temp = 0;
//     for (int i = 0; i < 1; i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             temp = array[i, array.GetLength(1) - 1 - j];
//             array[i, array.GetLength(1) - 1 - j] = array[array.GetLength(0)-1, array.GetLength(1) - 1 - j];
//             array[array.GetLength(0)-1, array.GetLength(1) - 1 - j] = temp;
//         }
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"|{array[i, j]}|");
//         }
//         Console.WriteLine();
//     }
// }



// // Задача 3: Задайте прямоугольный двумерный массив. 
// //Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.Write("Введите количество строк в массиве - ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов в массиве - ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] arr = new int[rows, columns];
// FillArr(arr);
// Console.WriteLine();
// int result = FindSum(arr);
// Console.WriteLine($"Номер строки с наименьшей суммой элементов равен = {result}");
// void FillArr(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//             Console.Write($"|{array[i, j]}|");
//         }
//         Console.WriteLine();
//     }
// }

// int FindSum(int[,] array)
// {
//     int minSum = 0;
//     int numRows = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minSum += array[0, i];
//     }
//     for (int i = 1; i < array.GetLength(0); i++)
//     {

//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i, j];
//         }

//         if (sum < minSum)
//         {
//             minSum = sum;
//             numRows = i;
//         }
//     }

//     return numRows;
// }



// // Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. 
// // Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца


// Console.Write("Введите количество строк в массиве - ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов в массиве - ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] arr = new int[rows, columns];
// FillArr(arr);
// PrintArray(arr);

// int minRow = 0;
// int minColum = 0;
// int minVal = arr[0, 0];

// minValue(arr);
// Console.WriteLine();
// int[,] newArray = CreateNewArray(arr, minRow, minColum);
// PrintArray(newArray);

// void FillArr(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 100);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"|{array[i, j]}|");
//         }
//         Console.WriteLine();
//     }
// }
// void minValue(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < minVal)
//             {
//                 minVal = array[i, j];
//                 minRow = i;
//                 minColum = j;
//             }
//         }
//     }
//     Console.Write($"Минимальное значение элемента массива = {minVal} \nНомер строки этого элемента = {minRow} \nНомер столбца этого элемента = {minColum}");
// }
// int[,] CreateNewArray(int[,] array, int minRow, int minColum)
// {
//     int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
//     int newRow = 0;
//     int newColumn = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         if (i != minRow)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (j != minColum)
//                 {
//                     newArray[newRow, newColumn] = array[i, j];
//                     newColumn++;
//                 }
//             }
//             newRow++;
//             newColumn = 0;
//         }
//     }
//     return newArray;
// }
