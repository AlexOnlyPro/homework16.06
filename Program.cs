Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9

void FillArray(double[,] array)
{
    for (int i =0;i<array.GetLength(0);i++)
        for (int j =0;j<array.GetLength(1);j++)
            array[i,j] = new Random().NextDouble()*10-5;
}

void PrintArray(double[,] array)
{
    for (int i =0;i<array.GetLength(0);i++)
        {
        for (int j =0;j<array.GetLength(1);j++)
            Console.Write($"{Math.Round(array[i,j],1),4}");
        System.Console.WriteLine();
        }
}


Console.Clear();
System.Console.WriteLine("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов ");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] array = new double [rows,cols];
FillArray(array);
PrintArray(array);

Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
и возвращает позицию этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

int rows = 3;
int cols = 4;
int[,] array = new int[rows, cols];
System.Console.WriteLine("Введите число от 0 до 9 для поиска : ");
int num = int.Parse(Console.ReadLine());
FillArray(array);
PrintArray(array);
SearchNum(array);


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],2} ");
        System.Console.WriteLine();
    }
}

bool SearchNum(int[,] array)
{
    bool flag = false;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if(array[i,j]==num)
            {
            System.Console.WriteLine($"Число {num} на {i+1} строке, в {j+1} ряду.");
            flag = true;
            }
            if (flag == false)
                System.Console.WriteLine("Нет такого числа."); 
            return flag;
}



Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

void FillArray(int[,] array)
{
    for (int i =0;i<array.GetLength(0);i++)
        for (int j =0;j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(0,10);
}

void PrintArray(int[,] array)
{
    for (int i =0;i<array.GetLength(0);i++)
        {
        for (int j =0;j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],3}    ");
        System.Console.WriteLine();
        }
}

void Arithmetic(int[,] array, int[] garray)
{

    for (int i =0;i<array.GetLength(0);i++)
        for (int j =0;j<array.GetLength(1);j++)
        {
            garray[j] += array[i,j];
        }
           
}

void Mean(int [,] array,int [] garray)
{
   for (int i = 0; i < garray.Length; i++)
   {
    garray[i] = garray[i]/array.GetLength(0);
        System.Console.WriteLine(garray[i]);
   }
}
Console.Clear();
System.Console.WriteLine("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows,cols];
int[] garray = new int[cols];
FillArray(array);
PrintArray(array);
Arithmetic(array, garray);
Mean(array,garray);

Console.Clear();
int n = 4;
int[,] array = new int[n, n];
FillArray(array);
PrintArray(array);
HardSort(array);
System.Console.WriteLine();
PrintArray(array);

// ////////////// HARD SORT///////////////

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}


void HardSort(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
            for (int a = 0; a < n; a++)
                for (int b = 0; b < n; b++)
                    if (array[a,b] > array[i,j])
                    {
                        temp = array[a,b];
                        array[a,b] = array[i,j];
                        array[i,j] = temp;
                    }
}


