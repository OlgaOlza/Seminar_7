// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

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
// int FindIndexSame(int[,] matrix)
// {  int summ=0;
//     for (int i = 0; i < matrix.GetLength(0); i++) //3
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(2)

//         {
//             if (i == j)

//                 summ = matrix[i, j]+ summ;
//         }

//     }
//     return summ;
// }
// int[,] array2D = CreateMatrixRndInt(3, 4, -50, 50);
// PrintMatrix(array2D);
// Console.WriteLine();
// Console.WriteLine(FindIndexSame(array2D));

// Вариант 2


int rows = GetInfo("Введите количество строк массива: ");
int columns = GetInfo("Введите количество столбцов массива: ");
int[,] massive = DoDoubleMassive(rows, columns, 0, 9);

string MainDiagonalSum(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            if (i == j)
            {
                sum += matr[i, j];
                return ($"{string.Join("+", matr[i, j])} = {sum}");
            }
        }
    }
    return "";
}


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
MainDiagonalSum(massive);
Console.WriteLine();
PrintDoDoubleMassive(massive);


