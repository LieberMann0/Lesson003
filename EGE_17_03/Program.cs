/*В файле содержится последовательность из 10 000 целых положительных чисел.
Каждое число не превышает 10 000. Определите и запишите в ответе сначала количество
пар элементов последовательности, для которых произведение элементов кратно 26,
затем максимальную из сумм элементов таких пар. В данной задаче под парой подразумевается
два различных элемента последовательности. Порядок элементов в паре не важен.*/


int[] arr = new int[10000];
int a = 1;
for (int i = 0; i < 10000; i++)
{
    arr[i] = a;
    ++a;
}

int c = 0;
int sum = 0;
int max = 0;

for (int i = 0; i < 9999; i++)
{
    for (int j = i + 1; j < 10000; j++)
    {
        int b = (arr[i]) * (arr[j]);
        if (b%26 == 0)
        {
            c = ++c;
            sum = (arr[i]) + (arr[j]);            
            if (max < sum) max = sum;
        }        
    }    
}
Console.WriteLine(c +"   "+ max);
