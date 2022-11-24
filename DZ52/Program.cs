// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Programm to find the arithmetical average in every column.");

Console.Write("Input the rows number: ");
int rows;

while (!int.TryParse(Console.ReadLine()!, out rows) || rows <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.WriteLine("Input the rows number: ");
}

Console.Write("Input the columns number: ");
int columns;

while (!int.TryParse(Console.ReadLine()!, out columns) || columns <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.WriteLine("Input the columns number: ");
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

void AverageOfColumn (int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        var sum = 0;
        double average = 0;
        
        for (var j = 0; j < array.GetLength(1); j++)
        {
            sum += array[j, i];
            
        }
        
        average = (double)sum / rows;
        Console.WriteLine($"The arithmetical average of column {i+1} is " + Math.Round(average, 1));
    }
}

CreateArray(rows, columns);
PrintArray(array);
AverageOfColumn(array);