// Дан целочисленный двумерный массив, размерности n х m. Найти количество отрицательных элементов, больше -9.

int a = 4;
int b = 4;
int[,] array = new int[a, b];

Random rnd = new Random();
for (int rows = 0; rows < a; rows++)
{
    for (int colums = 0; colums < b; colums++)
    {
        array[rows, colums] = rnd.Next(-20, 10);
        Console.Write($"{array[rows, colums], 4}");
    }
    Console.WriteLine();
}

int NegateveElement = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if ((array[i, j] < 0) && (array[i, j] > -9)) 
        {
            NegateveElement = ++NegateveElement;
        }
    }
}
Console.WriteLine(NegateveElement);