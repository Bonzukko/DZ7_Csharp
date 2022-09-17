Console.Clear();
int m = new Random().Next(2, 11);
int n = new Random().Next(2, 11);
Console.WriteLine($"m = {m}, n = {n}.");
double[,] matrix = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(-99, 100) + Math.Round(new Random().NextDouble(), 2);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}