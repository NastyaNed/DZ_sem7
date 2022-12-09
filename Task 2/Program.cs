// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int GetNumber(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        string? num = Console.ReadLine();
        if (int.TryParse(num, out int number) == false)
            Console.WriteLine("Введено не число");
        else
        {
            if (number <= 0)
                Console.WriteLine("Задайте позицию больше 0");
            else
                return number;
        }
    }
}

int[,] ArrayRandom()
{
    int[,] arr = new int[new Random().Next(2, 10), new Random().Next(2, 10)];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = rnd.Next(0, 100);
    }
    return arr;
}

void PositionElement(int[,] arr, int row, int column)
{
    Console.WriteLine("Двумерный массив:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
    if (row <= (arr.GetLength(0) + 1) & row > 0 & column <= (arr.GetLength(1) + 1) & column > 0)
        Console.WriteLine($"Элемент [{row};{column}] равен числу:{arr[row - 1, column - 1]}");
    else Console.WriteLine($"[{row};{column}]-> такого числа в массиве нет");

}


int row = GetNumber("Введите число в строке : ");
int column = GetNumber("Введите число столбце: ");
PositionElement(ArrayRandom(), row, column);