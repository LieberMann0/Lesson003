// Написать программу замену элементов массива на противоположные

int ind = 10;
int[] arr = new int[ind];

for (int i = 0; i < ind; i++)
{
    arr[i] = new Random().Next(1, 11);
    Console.WriteLine(arr[i]);
}

Console.WriteLine();

int j = 0;
int temp = 0;

for (int i = 0; i < (ind / 2); i++)
{
    temp = arr[i];
    arr[i] = arr[(ind - 1) - j];
    arr[(ind - 1) - j] = temp;
    j++;
}

for (int i = 0; i < ind; i++)
{
    Console.WriteLine(arr[i]);
}

