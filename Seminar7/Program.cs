//Задача 1. Вывести сумму элементов главной диагонали массива
/*
int SumOfDiagonal(int[,] quad)
{
    int sum = 0;
    for(int i = 0; i < quad.GetLength(0); i++)
    {
       sum += quad[i,i];
    }

    return sum;
}

Console.Write("Input size of matrix: ");
int size = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [size,size];
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j<matrix.GetLength(1); j++)
    {
        matrix [i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
Console.Write(SumOfDiagonal(matrix));

// Задайте массив размера m на n Каждый элемент в массиве находится по формуле A m+n = m+n. Выведите полученный массив на экран.
int [,] CreateArray(int size1, int size2)
{
    int[,] array = new int [size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            array[i,j] = i + j;
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}
CreateArray(10,10);
*/
// Задайте двумерный массив. Найдите элементы у которых оба индексы четные и замените их на их квадраты
int[,] ChangeArrayQuadEven(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i,j] *= array[i,j];
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

int [,] CreateDimenArray()
{
    Console.Write("Введите количество строк: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int y = Convert.ToInt32(Console.ReadLine());
    int [,] newArray = new int [x,y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            int newNumber = new Random().Next(0,10);
            Console.Write(newArray[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newArray;
}
ChangeArrayQuadEven(3,4);
