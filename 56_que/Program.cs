//  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
//
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  5 2 6 7
//  Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



int InputNum(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
return new int[rows, columns];
}

void Fill2DArrayRandom(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
 

}

void MinSumRow(int[,] array)
{
    int minTempRow = 0;
    int minTempSumRow = 0;
    int sumTempRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
        {
             minTempRow += array[0, i];
        }
         for (int i = 0; i < array.GetLength(0); i++)
         {
             for (int j = 0; j < array.GetLength(1); j++) sumTempRow += array[i, j];
             if (sumTempRow < minTempRow)
             {
                 minTempRow = sumTempRow;
                 minTempSumRow = i;
             }
             sumTempRow = 0;
         }
         Console.Write($"строка {minTempSumRow + 1} имеет меньшую сумму");
}


 void Print2DArray(int[,] array)
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
            {
              Console.Write($"{array[i, j]}\t");
            }
             Console.WriteLine();
     }
 }

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

int[,] myArray = Create2DArray(rows, columns);

Fill2DArrayRandom(myArray);
Print2DArray(myArray);
MinSumRow(myArray);

