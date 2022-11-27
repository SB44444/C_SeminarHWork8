/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // Метод для создания двумерного int массива
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)        
        for(int j = 0; j < columns; j++)   
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;        
}
void DecreasingRow2dArray(int[,] array)  // Метод сотрировки массива по убыванию значений в строке
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int max = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = max;
                }
            }
        }
    }
}

void Show2dArray(int[,] array)  //                                  Метод вывода массива 2D
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "| ");
        Console.WriteLine();    
    }
    Console.WriteLine(); 
}
Console.WriteLine("Input number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colomns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a minimum of possible value:");
int  min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the maximum of possible value:");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myRandomArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myRandomArray);
DecreasingRow2dArray(myRandomArray);
Show2dArray(myRandomArray);
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // Метод для создания двумерного int массива
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)        
        for(int j = 0; j < columns; j++)   
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;        
}

void FindNumberMinimalRow(int[,] array)
{
    int minNumber = 0;  // Номер ряда
    int minSum = 0;     // Сумма минимального ряда
    int sumTamp = 0;    // Временная переменная
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSum += array[0, j];               // Считаем сумму первого ряда, принимаем за минимальную 
    }        
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            sumTamp += array[i, j];             // Считаем сумму каждого ряда
        }    
            if (sumTamp < minSum)               // Если сумма ряда меньше минимального, переприсваиваем значение
            {
                minSum = sumTamp;
                minNumber = i;
            }
            
    sumTamp = 0;
    }          
    Console.WriteLine($" The row with minimum sum of numbers {minNumber +1}");
}
void Show2dArray(int[,] array)  //                                  Метод вывода массива 2D
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "| ");
        Console.WriteLine();    
    }
    Console.WriteLine(); 
}
Console.WriteLine("Input number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colomns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a minimum of possible value:");
int  min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the maximum of possible value:");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myRandomArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myRandomArray);
FindNumberMinimalRow(myRandomArray);
*/
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/