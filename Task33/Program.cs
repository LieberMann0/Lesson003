// Задать массив из 12 элементов, заполненных числами из [-9,9].
// Найти сумму положительных/отрицательных элементов массива

int[] array = new int [12];

int sumPos;
int sumNeg;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.WriteLine(array[i]);

    if (array[i] > 0) sumPos = sumPos + array[i];
    if (array[i] < 0) sumNeg = sumNeg + array[i];
}
 
Console.WriteLine(sumPos);
Console.WriteLine(sumNeg);