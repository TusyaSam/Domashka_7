// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-10, 10);
//         }
//         Console.WriteLine();
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// FillArray(array);
// PrintArray(array);



//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int [m,n];

// void FillArray(int [,] array)
// {
//     for (int i=0; i<array.GetLength(0);i++)
//     {
//         for (int j=0; j<array.GetLength(1); j++)
//         array [i,j]=i+j;
//     }

// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// FillArray(array);
// PrintArray(array);


// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//         Console.WriteLine();
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void ReplaceArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
//             {
//                 array[i, j] = array[i, j] * array[i, j];
//             }
//         }
//     }
// }

// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// ReplaceArray(array);
// PrintArray(array);



































// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// double [,] array = new double [m,n];

// for (int i=0; i<array.GetLength(0); i++) 
// {
//     for (int j=0; j<array.GetLength(1); j++) 
//     {
//         array[i,j]=new Random().NextDouble() + new Random().Next(0,11);  
//         Console.Write( Math.Round(array[i,j],2)+ " ");
//     }
//     Console.WriteLine();
// }





// Задача 50. Напишите программу, которая на вход принимает
//  позиции элемента в двумерном массиве, и возвращает значение
//  этого элемента или же указание, что такого элемента нет.
// В 50 задаче желательно проверять и нижнюю границу индекса, а ошибка возникает, так как вы в конце метода 
// возвращаете значение из массива, используя индексы, которых нет в массиве
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер строки искомого элемента: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца искомого элемента: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 100);
//         }
//         Console.WriteLine();
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int Metod(int[,] array)
// {
//     if (x > array.GetLength(0) || y > array.GetLength(1)) System.Console.WriteLine("Искомый элемент за пределами массива");

//     else if (x < 0 || y < 0) System.Console.WriteLine("Искомый элемент за пределами массива");

//     {

//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (x == i && y == j) ;
//             }
//         }
//     }
//     return (array[x - 1, y - 1]);
// }

// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// System.Console.WriteLine($"Искомый элемент {Metod(array)}");



// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.
// В 52 задаче - SredneeArif[i] = sum / array.GetLength(0); - выводим за внутренний массив. И переменную sum - делаем double

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
        Console.WriteLine();
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);

double[] SredneeArif = new double[n];   // массив [0,1,2,3,4] если 5 столбцов

for (int i = 0; i < array.GetLength(1); i++)  // столбцы, начинаем с [j,0],[j,1],[j,2]
{
    double sum = 0;                                // обнуляем счетчик суммы
    for (int j = 0; j < array.GetLength(0); j++) // строки, начинаем с [0,0],[0,1],[0,2]
    {
        sum = (sum + array[j, i]);
        SredneeArif[i] = sum / array.GetLength(0);
    }

    System.Console.WriteLine($"Среднее арифметическое столбца = {sum}/{m} это {SredneeArif[i]}"); 
}
System.Console.WriteLine();







//  Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m,n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(-100, 100);
//         Console.Write(array[i, j]+" ");
//     }   
// Console.WriteLine();
// }



// Задача 48: Задайте двумерный массив размера m на n, каждый
//  элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m,n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = i+j;
//         Console.Write(array[i, j]+" ");
//     }   
// Console.WriteLine();
// }



// Задача 49: Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-10, 10);
//         }
//         Console.WriteLine();
//     }
// }

// void Replace(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0) array[i, j] *= array[i, j];
//         }
//     }

// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// Replace(array);
// PrintArray(array);




// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
//  находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-10, 10);
//         }
//         Console.WriteLine();
//     }
// }
// int Sum(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j) sum = sum + array[i, j];
//         }
//     }
//     return sum;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// System.Console.WriteLine($"Сумма элементов по диагонали = {Sum(array)}");

