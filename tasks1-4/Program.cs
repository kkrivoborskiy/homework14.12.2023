// 1.   Напишите программу, которая на вход принимает
//      позиции элемента в двумерном массиве, 
//      и возвращает значение этого элемента или же указание,
//      что такого элемента нет.

// Console.Write("Введите номер строки: ");
// int index1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца: ");
// int index2 = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[4,5];
// void CreateArray()
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(0, 10);
//     }
// }
// void PrintArray()
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j]+" ");
//         Console.WriteLine();
//     }
// }

// CreateArray();
// PrintArray();

// if (index1>array.GetLength(0) || index2>array.GetLength(1))
//     Console.Write("такого элемента нет");
// else
//     Console.Write(array[index1-1,index2-1]);



// 2.  Задайте двумерный массив. Напишите программу,
//     которая поменяет местами первую и последнюю строку массива.

// int[,] array = new int[4,5];
// void CreateArray()
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(0, 10);
//     }
// }
// void PrintArray()
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j]+" ");
//         Console.WriteLine();
//     }
// }
// CreateArray();
// PrintArray();

// void ChangeArrayLines()
// {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         int temp = array[0, i];
//         array[0,i] = array[array.GetLength(0)-1, i];
//         array[array.GetLength(0)-1, i] = temp;
//     }
// }

// ChangeArrayLines();
// Console.WriteLine();
// PrintArray();



// 3.   Задайте прямоугольный двумерный массив. 
//      Напишите программу, которая будет находить 
//      строку с наименьшей суммой элементов.

// int[,] array = new int[4,5];
// void CreateArray()
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(0, 10);
//     }
// }
// void PrintArray()
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j]+" ");
//         Console.WriteLine();
//     }
// }
// CreateArray();
// PrintArray();

// int minSum = 0;
// for(int i = 0; i < array.GetLength(1); i++)  
//     minSum+=array[0,i];
// for(int i = 0; i < array.GetLength(0); i++)
// {
//     int sum = 0;
//     for(int j = 0; j < array.GetLength(1); j++)
//         sum+=array[i,j];
//     if (sum < minSum)
//         minSum = sum;
// }
// Console.WriteLine(minSum);



// 4.   Задайте двумерный массив из целых чисел. Напишите программу,
//      которая удалит строку и столбец, на пересечении которых 
//      расположен наименьший элемент массива. Под удалением понимается 
//      создание нового двумерного массива без строки и столбца

int[,] array = new int[4,5];
void CreateArray()
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(10, 101);
    }
}
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j]+" ");
        Console.WriteLine();
    }
}
CreateArray();
PrintArray(array);

int minI = 0, minJ = 0;
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j] < array[minI,minJ])
        {
            minI = i;
            minJ = j;
        }
    }
}
int[,] array2 = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
for(int i = 0; i < array2.GetLength(0); i++)
{
    for(int j = 0; j < array2.GetLength(1); j++)
    {
        if      (i < minI && j < minJ)
            array2[i,j] = array[i,j];
        else if (i < minI && j >= minJ)
            array2[i,j] = array[i,j+1];
        else if (i >= minI && j < minJ)
            array2[i,j] = array[i+1,j];
        else if (i >= minI && j >= minJ)
            array2[i,j] = array[i+1,j+1];
    }
}
Console.WriteLine($"наименьший элемент = {array[minI,minJ]}. ({minI+1},{minJ+1})");
PrintArray(array2);