//  Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
//  Например, даны 2 матрицы:
//  2 4 | 3 4
//  3 2 | 3 3
//  Результирующая матрица будет:
//  18 20
//  15 18

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

void arbetMedNewArray(int[,] array, int[,] array2, int[,]newArray)
{
    
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        newArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            newArray[i, j] += array[i, k] * array2[k, j];
        }
    }
}
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
     Console.WriteLine();
 }

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int[,] myArray = Create2DArray(rows, columns);
int[,] myArray2 = Create2DArray(rows, columns);
int[,] newArray = Create2DArray(rows, columns);
Fill2DArrayRandom(myArray);
Fill2DArrayRandom(myArray2);

Print2DArray(myArray);
Print2DArray(myArray2);
arbetMedNewArray(myArray, myArray2,newArray);
Print2DArray(newArray);