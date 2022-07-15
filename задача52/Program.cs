int[, ] CreateMatr(int n, int m)
{
int[, ] matrix = new int[n ,m];
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(1, 10);
Console.Write(matrix[i, j] + " ");
}
Console.WriteLine();
}
return matrix;
}


void PrintMatr(int[, ] matrix)
{
Console.WriteLine();
double SumOfColumnElements = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
SumOfColumnElements += matrix[i, j];
}
}
Console.Write($"{ SumOfColumnElements / matrix.GetLength(0)} ");
}
Console.WriteLine("Введите кол-во строк в матрице:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в матрице:");
int m = Convert.ToInt32(Console.ReadLine());
PrintMatr(CreateMatr(n, m));