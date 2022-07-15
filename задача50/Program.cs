int[, ] CreateMatr(int n, int m)
{
int[, ] matrix = new int[n ,m];
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(1, 10);
}
}
return matrix;
}


void PrintMatr(int[, ] matrix)
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

void FindNumber(int[,] matrix, int find)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (matrix[i, j] != find)
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", matrix[i, j]);
}
}
}
}
PrintMatr(CreateMatr(3, 4));
int n = FindNumber(matrix, 4);
Console.WriteLine(n);