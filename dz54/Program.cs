//  Задайте двумерный массив. Напишите программу, 
//  которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] massiv = new int[4, 4];
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i, j] = new Random().Next(0, 30);
        Console.Write($"{massiv[i, j]}  ");
    }
    Console.WriteLine();

    for (int k = 0; k < massiv.GetLength(1); k++)
    {
        int index = k;
        for (int l = k + 1; l < massiv.GetLength(1); l++)
        {
            if (massiv[i, index] < massiv[i, l])
            { index = l; }
        }
        int help = massiv[i, k];
        massiv[i, k] = massiv[i, index];
        massiv[i, index] = help;
        Console.Write($"{massiv[i, k]}  ");
    }
    Console.WriteLine();
    Console.WriteLine();
}
