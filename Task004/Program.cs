// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

// Вариант 1

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++) //3
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(2)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1); // 2 - 3
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
//             else Console.Write($"{matrix[i, j],4} ");
//         }
//         Console.WriteLine("|");
//     }
// }
// int[,] FindIndexEvenToSqver(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) //3
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(2)
//         {
//             if (i % 2 == 0 && j % 2 == 0)

//                 matrix[i, j] = matrix[i, j] * matrix[i, j];

//         }

//     }
//     return matrix;
// }
// int[,] array2D = CreateMatrixRndInt(9, 4, -50, 50);
// PrintMatrix(array2D);
// Console.WriteLine();
// PrintMatrix(FindIndexEvenToSqver(array2D));

//Вариант 2

int[,] NewDoubleMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < massive.GetLength(1); j = j + 2)
        {
            massive[i, j] = massive[i, j] * massive[i, j];
        }
    }
return massive;
}

int rows = GetInfo("Введите количество строк массива: ");
int columns = GetInfo("Введите количество столбцов массива: ");
int[,] massive = DoDoubleMassive(rows, columns, 0, 9);

void PrintDoDoubleMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] DoDoubleMassive(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

PrintDoDoubleMassive(massive);
NewDoubleMassive(massive);
Console.WriteLine();
PrintDoDoubleMassive(massive);