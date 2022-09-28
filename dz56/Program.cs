// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
int[,] massiv = new int[4, 4];
int[] massivSumm = new int[massiv.GetLength(0)];
for (int i = 0; i < massiv.GetLength(0); i++)
{
    int summ = 0;
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i, j] = new Random().Next(0, 30);
        Console.Write($"{massiv[i, j]}  ");
        summ = summ + massiv[i, j];
    }
    Console.WriteLine();
    Console.WriteLine($"сумма {i + 1} строки = {summ}");
    massivSumm[i] = summ;
    
}
int minIndex = 0;
for (int i = 0; i < massivSumm.Length; i++)
{
    if (massivSumm[minIndex] > massivSumm[i])
    { minIndex = i; }
    Console.Write($"{massivSumm[i]}  ");
}
Console.WriteLine($"минимальная сумма элементов находится в строке {minIndex+1} ");
