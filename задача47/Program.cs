double[, ] CreateMatr(int n, int m)
{
double[, ] matrix = new double[n ,m];
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Random rand = new Random();
matrix[i, j] = rand.NextDouble();
matrix[i, j] = Math.Round(matrix[i, j], 2);
}
}
return matrix;
}


void PrintMatr(double[, ] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write(matrix[i, j] + " ");
}
Console.WriteLine();
}
}

PrintMatr(CreateMatr(3, 4));