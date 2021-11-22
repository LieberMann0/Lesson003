// Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение четных элементов.

int n = 3;
int m = 3;
int[,] arr = new int[n, m];


Random rnd = new Random();
for (int rows = 0; rows < n; rows++)
{
    for (int columns = 0; columns < m; columns++)
    
    {
        arr[rows, columns] = rnd.Next(1, 100);
        Console.Write($"{arr[rows, columns], 4} ");
    }
    Console.WriteLine();
}

int sumEven = 0;
double compEven = 1;

for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j]%2 == 0)
                {
                    sumEven = sum + arr[i, j];
                    compEven = comp * arr[i, j];
                }
        }
        Console.WriteLine();
    }

Console.WriteLine(Convert.ToInt32(sum));
Console.WriteLine(Convert.ToDouble(comp));