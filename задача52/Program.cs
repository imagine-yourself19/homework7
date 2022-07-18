int[, ] CreateMatrix(int[, ] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
//int x = Convert.ToInt32(Console.ReadLine());
int x = new Random().Next(1, 1000);
matrix[i , j] = x;
}
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write(matrix[i, j] + "\t");
}
Console.WriteLine();
}

return matrix;
}


void AvgMatrix(int[, ] matrix)
{
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
double avg = 0;
for(int j = 0; j < matrix.GetLength(1); j++)
{
avg = avg + matrix[j, i];
}
Console.WriteLine(i + 1 + " столбец: " + avg/matrix.GetLength(0));
}
}

int[, ] matrix = new int[4, 4];
matrix = CreateMatrix(matrix);
AvgMatrix(matrix);