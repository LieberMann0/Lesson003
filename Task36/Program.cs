// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел


int[] arr = new int[new Random().Next(10, 21)];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100, 1000);
    Console.WriteLine(arr[i]);
}

Console.WriteLine();

int even = 0;
int odd = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]%2 > 0) odd = ++odd;
    if (arr[i]%2 == 0) even = ++even;
}

Console.WriteLine("Четных чисел - "+even);
Console.WriteLine("Нечетных чисел - "+odd);
