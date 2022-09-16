/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine(" Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в двумерном массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] newArray (int number1, int number2, int minValue, int maxValue)
{
    double[,] result = new double[number1, number2];
    for (int i= 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
 return result;
}
void showArray (double [,] array)
{
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
double [,] finalyArray = newArray(m, n, 10, 100);
showArray(finalyArray);
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите первую кординату элемента двумерного: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введит евторую кординату элемента двумерного массива: ");
int num2 = Convert.ToInt32(Console.ReadLine());
void showNumber (double [,] array)
{
    if (num1 < array.GetLength(0) && num2 < array.GetLength(1)) Console.WriteLine(array[num1, num2]);
    else Console.WriteLine($"{num1}{num2} ---> такого числа нет!");
}
showNumber(finalyArray);*/



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*/


Console.WriteLine(" Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в двумерном массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] newArray (int number1, int number2, int minValue, int maxValue)
{
    int[,] result = new int[number1, number2];

    for (int i= 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
 return result;
}


void showArray (int [,] array)
{
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void showSum( int [,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
   {
      double sum = 0;
      for (int i = 0; i < arr.GetLength(0); i++)
      {
          sum += arr[i, j];
      }
    Console.Write($"{ sum / arr.GetLength(0)} ");
  }
   Console.ReadLine();
   }

int [,] testArray = newArray(m, n, 1, 11);
showArray(testArray);
showSum(testArray);