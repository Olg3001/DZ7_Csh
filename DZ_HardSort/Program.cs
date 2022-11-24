// Задача HARD SORT необязательная. Считается за три обязательных. Задайте двумерный 
// массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

Console.WriteLine("Programm to sort the array from min to max");

Console.Write("Input the rows number: ");
int rows;

while (!int.TryParse(Console.ReadLine()!, out rows) || rows <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.Write("Input the rows number: ");
}

Console.Write("Input the columns number: ");
int columns;

while (!int.TryParse(Console.ReadLine()!, out columns) || columns <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.Write("Input the columns number: ");
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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6}", array[i, j]);
        }
        
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[k, l] < array[i, j])
                    {
                        int temp = array[k, l];
                        array[k, l] = array[i, j];
                        array[i, j] = temp;
                    }
                }
            }
        }
    }

    return array;
}

CreateArray(rows, columns);
Console.WriteLine("Created array:");
PrintArray(array);
Console.WriteLine("Sorted Array:");
SortArray(array);
PrintArray(array);