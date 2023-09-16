//  Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
//  построчно выводить массив, добавляя индексы каждого элемента.
//  Массив размером 2 x 2 x 2
//  66(0,0,0) 25(0,1,0)
//  34(1,0,0) 41(1,1,0)
//  27(0,0,1) 90(0,1,1)
//  26(1,0,1) 55(1,1,1)

int InputNum(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}

int[,,] Create3DArray(int rows, int columns, int col3)
{
return new int[rows, columns, col3];
}

void Fill3DArrayRandom(int[,,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            { 
                array[i, j, k] = new Random().Next(10, 100); // Даже в голову не лезит другой
            }
        }
    }


}

void FillArray3D(int[,,] array)
{
    int count = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] += count;
                count += 1;
            }
        }
    }


}


 void Print3DArray(int[,,] array)
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.WriteLine();
           for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
                }
            }
             
     }
     Console.WriteLine();
 }

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int col3 = InputNum("Введите количество 3: ");
int[,,] myArray = Create3DArray(rows, columns, col3);
Fill3DArrayRandom(myArray);
FillArray3D(myArray);
Print3DArray(myArray);


