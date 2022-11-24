// Задача 50. Напишите программу, которая на вход принимает значение элемента 
// в двумерном массиве, и возвращает позицию этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Programm to create the random 2D array with random real numbers.");

Console.Write("Input the rows number:\t");
int rows;

while (!int.TryParse(Console.ReadLine()!, out rows) || rows <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.WriteLine("Input the rows number:\t");
}

Console.Write("Input the columns number:\t");
int columns;

while (!int.TryParse(Console.ReadLine()!, out columns) || columns <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.WriteLine("Input the columns number:\t");
}

Console.Write("Input number to check:\t");
int check;

while (!int.TryParse(Console.ReadLine()!, out check))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong array");
    Console.ResetColor();
    Console.WriteLine("Input number to :\t");
}

var array = CreateArray(rows, columns);

int[,] CreateArray(int rows, int columns)
{
    Random random = new Random();
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 11);
        }
    }

    return array;
}

void PrintArray(int[,] input)
{
    Console.WriteLine("Created array:");
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int j = 0; j < input.GetLength(1); j++)
        {
            Console.Write("{0,6}", input[i, j]);
        }

        Console.WriteLine();
    }
}

bool ExistsOrNot(int[,] array)
{
    bool exists = true;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == check)
                return false;
        }

    }

    return exists;
}

void CheckNumberPosition(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == check)
                Console.WriteLine($"The inputed number is in the row {i+1} and column {j+1}");
            
        }
    }
}

CreateArray(rows, columns);
PrintArray(array);
CheckNumberPosition(array);

if (ExistsOrNot(array))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("There are no such number in the created array");
    Console.ResetColor();
}
else 
    CheckNumberPosition(array);