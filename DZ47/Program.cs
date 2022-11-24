// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateArray(int rows, int columns)
{
    Random random = new Random();

    double[,] array = new double[rows, columns];
    
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(-100, 101) / 10.0;
        }
    }
    
    return array;
}

void PrintArray(double[,] array)
{
    Console.WriteLine("Created Array:");

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6}", array[i, j]);
        }

        Console.WriteLine();
    }
}

Console.WriteLine("Programm to create the random 2D array with random real numbers.");
Console.WriteLine("Press 'Enter' after every inputed number");
Console.Write("Input the rows number: ");
int rows;

while(!int.TryParse(Console.ReadLine()!, out rows) || rows <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.Write("Input the rows number: ");
}

Console.Write("Input the columns number: ");
int columns;

while(!int.TryParse(Console.ReadLine()!, out columns) || columns <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.Write("Input the colums number: ");
}

var array = CreateArray(rows, columns);
PrintArray(array);