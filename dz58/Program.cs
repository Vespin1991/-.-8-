// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] massiv1 = new int[2, 2];
for (int i = 0; i < massiv1.GetLength(0); i++)
{
    for (int j = 0; j < massiv1.GetLength(1); j++)
    {
        massiv1[i, j] = new Random().Next(0, 30);
        Console.Write($"{massiv1[i, j]}  ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] massiv2 = new int[2, 2];
for (int i = 0; i < massiv2.GetLength(0); i++)
{
    for (int j = 0; j < massiv2.GetLength(1); j++)
    {
        massiv2[i, j] = new Random().Next(0, 30);
        Console.Write($"{massiv2[i, j]}  ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] massiv3 = new int[2, 2];
for (int i = 0; i < massiv3.GetLength(0); i++)
{
    for (int j = 0; j < massiv3.GetLength(1); j++)
    {
        int x = new int();
        for (int k = 0; k < massiv3.GetLength(1); k++)
        {
            x = x + massiv1[i, k] * massiv2[k, j];
        }
        massiv3[i, j] = x;
        Console.Write($"{massiv3[i, j]}  ");
    }
    Console.WriteLine();
}