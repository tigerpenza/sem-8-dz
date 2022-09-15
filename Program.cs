// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


/*
int[,] CreateNewArray()
{
    Console.WriteLine("Enter the number of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine();
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  |  ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
void SortedArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = j + 1; k < columns; k++)
                if (array[i, j] < array[i, k])
                {
                    int tmp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = tmp;
                }
}
int[,] newArr = CreateNewArray();
ShowArray(newArr);
SortedArray(newArr);
ShowArray(newArr);
                                                    */


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateNewArray()
{
    Console.WriteLine("Enter the number of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine();
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  |  ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
void MinSumRow(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int iRow = 0;
    int sumRows = 2147483647;
    for (int i = 0; i < rows; i++)
    {
        int sumRow = 0;
        for (int j = 0; j < columns; j++)
            sumRow += array[i, j];
        Console.WriteLine(sumRow);
        if (sumRow < sumRows)
        {
            sumRows = sumRow;
            iRow = i;
        }
    }
    Console.WriteLine(iRow);
}
int[,] newArr = CreateNewArray();
ShowArray(newArr);
MinSumRow(newArr);
                                            */






// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
int[,] CreateArray()
{
    Console.WriteLine("Enter the number of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine();
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  |  ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
int[,] MatrixProduct(int[,] firstArr, int[,] secondArr)
{
    int[,] arrayProduct = new int[firstArr.GetLength(0), firstArr.GetLength(1)];
    for (int i = 0; i < firstArr.GetLength(0); i++)
        for (int j = 0; j < firstArr.GetLength(1); j++)
            for (int k = 0; k < firstArr.GetLength(1); k++)
            {
                arrayProduct[i, j] += firstArr[i, k] * secondArr[k, j];
            }
    return arrayProduct;
}
int[,] firstArr = CreateArray();
int[,] secondArr = CreateArray();
ShowArray(firstArr);
ShowArray(secondArr);
int[,] arrayX = MatrixProduct(firstArr,secondArr);
ShowArray(arrayX);
                */


//   Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//   Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Create3dArray()
{
    Console.WriteLine("Enter the number of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter array depth: ");
    int g = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine();
    int[,,] array = new int[m, n, g];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            for (int k = 0; k < g; k++)
                array[i, j, k] = new Random().Next(10, 100);

    return array;
}

void Show3dArray(int[,,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                {
                    
                }
    

    }
    
    System.Console.WriteLine();
}

int[,,] new3dArr = Create3dArray();
Show3dArray(new3dArr);















// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)






























// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07