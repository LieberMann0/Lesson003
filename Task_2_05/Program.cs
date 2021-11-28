// Дан целочисленный двумерный массив, размерности n х m. Найти номера нечетных элементов, стоящих на четных местах. 


int a = 4;
int b = 4;
int[,] array = new int[a, b];

Random rnd = new Random();
for (int rows = 0; rows < a; rows++)
{
    for (int columns = 0; columns < 4; columns++)
    {
        array[rows, columns] = rnd.Next(1, 20);
        Console.Write($"{array[rows, columns], 4}");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if ((array[i, j]%2 == 1) && (i%2 == 1) && (j%2 == 1))
        {
            Console.WriteLine($"{i + 1},{j + 1}");
        }
    }
}


