/*
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] Fill2dArrayRandom(int RowNumber, int ColNumber)
{
    int[,] result = new int[RowNumber, ColNumber];
    for (int i = 0; i < RowNumber; i++)
    {
        for (int j = 0; j < ColNumber; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void Print2DArray(int[,] ArrayToPrint)
{
    Console.Write($"[ ]\t");
    const int StartLatterIndex = 65;
    for (int i = StartLatterIndex + 0; i < StartLatterIndex + ArrayToPrint.GetLength(1); i++)
    {
        if (ArrayToPrint.GetLength(0) > 0 && ArrayToPrint.GetLength(1) > 0) Console.Write($"[{((char)i)}]\t");

    }
    Console.WriteLine();
    for (int i = 0; i < ArrayToPrint.GetLength(0); i++)
    {
        if (ArrayToPrint.GetLength(0) > 0 && ArrayToPrint.GetLength(1) > 0) Console.Write("[" + i + "]\t");

        for (int j = 0; j < ArrayToPrint.GetLength(1); j++)
        {
            Console.Write(ArrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }

}

void AverageSumOfColumn(int[,] array)
{
    double sum = 0;
    double result = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int ColCount = 0; ColCount < array.GetLength(1); ColCount++)
    {
        for (int RowCOunt = 0; RowCOunt < array.GetLength(0); RowCOunt++)
        {
            sum = sum + array[RowCOunt, ColCount];
        }
        result = Math.Round(sum / array.GetLength(0), 1);
        Console.Write(result);
        if (ColCount < array.GetLength(1) - 1)
        {
            Console.Write("; ");
        }
        else
        {
            Console.Write(".");
        }
        sum = 0;
    }
}


int[,] MyArray = Fill2dArrayRandom(3, 4);
Print2DArray(MyArray);
Console.WriteLine();
AverageSumOfColumn(MyArray);
