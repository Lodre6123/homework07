// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Кол-во строк равно: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Кол-во столбцов равно: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];
FillArrayRandomNumbers(array);
PrintArray(array);
void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}