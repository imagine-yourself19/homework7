﻿int[, ] CreateMatrix(int[, ] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
int x = Convert.ToInt32(Console.ReadLine());
matrix[i , j] = x;
}
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write(matrix[i, j] + " ");
}
Console.WriteLine();
}

return matrix;
}


void CheckMatrix(int i, int j, int[, ] matrix)
{
if (i < matrix.GetLength(0) && j < matrix.GetLength(1) && i >= 0 && j >= 0)
Console.WriteLine(matrix[i, j]);
else
Console.WriteLine("Ты ошибся");
}

int[, ] matrix = new int[4, 4];
matrix = CreateMatrix(matrix);
Console.WriteLine("Введите координаты: ");
int i = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine());
CheckMatrix(i, j, matrix);