/*
Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] Fill2dArrayRandom(int RowNumber, int ColNumber)
{
    double[,] result = new double[RowNumber, ColNumber];
    for (int i = 0; i < RowNumber; i++)
    {
        for (int j = 0; j < ColNumber; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * 20 - 10, 2);
        }
    }
    return result;
}

void Print2DArray(double[,] ArrayToPrint)
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

int OnlyNumber(string CheckChar)
{
    string resulult = "0";
    char[] arr;

    arr = CheckChar.ToCharArray(0, CheckChar.Length);
    for (int i = 0; i < CheckChar.Length; i++)
    {
        if (char.IsDigit(arr[i]))
        {
            resulult = resulult + arr[i];
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
int RowIn = OnlyNumber(Row); // напишите пжлста в комментарии к ДЗ, как исправить...заранее Спасибо!)
Console.Write("Введите количество столбцов массива: ");
string? Col = Console.ReadLine();
int ColIn = OnlyNumber(Col);
double[,] MyArray = Fill2dArrayRandom(RowIn, ColIn);
Print2DArray(MyArray);