/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/
int[,] Fill2dArrayRandom(int RowNumber, int ColNumber)
{
    int[,] result = new int[RowNumber, ColNumber];
    for (int i = 0; i < RowNumber; i++)
    {
        for (int j = 0; j < ColNumber; j++)
        {
            result[i, j] = new Random().Next(1, 100);
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

void ShowMePosition2dArray(int[,] array, int position)
{
    int[] temparray = new int[array.GetLength(0) * array.GetLength(1)];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temparray[count] = array[i, j];
            count++;
        }
    }
    if (position < 0 || position > temparray.Length - 1)
    {
        Console.WriteLine("Такого числа нет");
    }
    else
    {
        int result = temparray[position];
        Console.Write($"Число на позиции {position} = {result}");
    }
}

int OnlyNumber(string CheckForNumber)
{
    string resulult = "0";
    char[] YourStringToChars;

    YourStringToChars = CheckForNumber.ToCharArray(0, CheckForNumber.Length);
    for (int i = 0; i < CheckForNumber.Length; i++)
    {
        if (char.IsDigit(YourStringToChars[i]))
        {
            resulult = resulult + YourStringToChars[i];
        }
        else
        {
            Console.WriteLine("Вы ввели нечисловое или отрицательное значение.");
            Console.WriteLine("Изначальное значение = 0.");
            break;
        }
    }
    int number = int.Parse(resulult);
    return number;
}


Console.Write("Введите количество строк массива: ");
string? Row = Console.ReadLine();
int RowInt = OnlyNumber(Row);
Console.Write("Введите количество столбцов массива: ");
string? Col = Console.ReadLine();
int ColInt = OnlyNumber(Col);
Console.WriteLine("Ваш случайный массив:");
int[,] MyArray = Fill2dArrayRandom(RowInt, ColInt);
Print2DArray(MyArray);
Console.Write("Какую позицию Вы хотите найти: ");
string? MyPosition = Console.ReadLine();
int MyPositionInt = OnlyNumber(MyPosition);
ShowMePosition2dArray(MyArray, MyPositionInt);
