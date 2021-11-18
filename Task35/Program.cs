// Определить, присутствует ли в заданном массиве, некоторое число 

void SearchNum(int[] array, int a)
{
    bool result = false;

            
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == a)
        {
            result = true;
            //Console.Write($"Искомое число в заданном массиве присутствует.");
            break;
        }                       
    }
    if (result == false) Console.Write($"Искомого числа в заданном массиве нет.");
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
Console.WriteLine();

SearchNum(arr, num);


