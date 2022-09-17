//Семинар 7. Домашняя работа 13.09.2022

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] CreateRandom2dArray(int m, int n){
//     double[,] array = new double[m, n];
//     for(int i = 0; i<m; i++){ 
//         for(int j = 0; j<n; j++){
//         array[i,j] = new Random().NextDouble()* 10; 
//                 }
//         }     
//     return array;
// }

// void Show2dArray(double[,] array){ 
//     for(int i = 0; i<array.GetLength(0); i++){ 
//         for(int j = 0; j<array.GetLength(1); j++){ 
//         Console.Write(Math.Round(array[i,j], 1) + " ");
//         }
//     Console.WriteLine();
//     }
// }

// double[,] array = CreateRandom2dArray(3,4);
// Show2dArray(array);




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет
// 1,2 -> 2


// int[,] array = {{1, 4, 7, 2},                                  
//                 {5, 9, 2, 3},
//                 {8, 4, 2, 4},
//                 {1, 7, 2, 2},
//                 {1, 2, 2, 2}};
                
                
// void SearchElementArray(int m, int n, int[,] array){
//     // Проверяем существует ли такая позиция
//     if(m < array.GetLength(0) && n < array.GetLength(1))  
//         // выводим число на экран        
//         Console.WriteLine($"Array[{m},{n}] = {array[m,n]}");      
//     else Console.WriteLine($"Array[{m},{n}] такого числа в массиве нет");     
// }

// Console.Write("Введите позицию m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// SearchElementArray(m,n, array);





// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     int[,] array = new int[rows,cols];
//     for(int i = 0; i<rows; i++)
//         for(int j = 0; j<cols; j++)
//             array[i,j] = new Random().Next(min, max+1);
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }
// int[] SumCols(int[,] array){
  
//   for(int i=0; i<array.GetLength(0); i++){
//     int newarray =0;
//     newarray[i] +=array[i,j];
//       cols++;
//       i = 0;
//   }
//   return array;

// }
// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);
// int sum = SumCols(sumarray);
// Console.WriteLine("Сумма столбцов: " + sumarray);
