// Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение элементов, кратных 3 и 5.

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

int summ = 0;
int comp = 1;

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if ((arr[i, j]%3 == 0) && (arr[i, j]%5 == 0));
        summ = summ + arr[i, j];
        comp = comp + arr[i, j];
    }
}

Console.WriteLine(summ);
Console.WriteLine(comp);