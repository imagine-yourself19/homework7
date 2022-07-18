int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
double[,] a = new double[n, m];
Random random = new Random();
for (int i = 0; i < n; i++)
{
for (int j = 0; j < m; j++)
{
a[i, j] = random.NextDouble() * 100;
Console.Write("{0,6:F2}/t", a[i, j]);
}
Console.WriteLine();
}