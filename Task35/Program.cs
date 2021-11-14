// Определить, присутствует ли в заданном массиве, некоторое число 

int SearchNum(int[] array, int a)
{
    int result;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == a)
        {
            result = Convert.ToInt32(Console.Write("Искомое число в заданном массиве присутствует."));
            break;
        }
        else result = Convert.ToInt32(Console.Write("Искомого числа в заданном массиве нет."));
    }
    return result;
}

int[] arr = new int[new Random().Next(10, 21)];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(10, 101);
    Console.WriteLine(arr[i]);
}

Console.WriteLine();

int num = new Random().Next(10, 101);

Console.WriteLine("Найти число "+num);

SearchNum(arr, num);


