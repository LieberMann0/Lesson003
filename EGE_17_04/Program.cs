/*В файле содержится последовательность из 10 000 целых положительных чисел.
Каждое число не превышает 10 000. Определите и запишите в ответе сначала количество пар элементов последовательности,
у которых сумма элементов кратна 60 и хотя бы один элемент из пары делится на 40,
затем максимальную из сумм элементов таких пар. В данной задаче под парой подразумевается два
различных элемента последовательности. Порядок элементов в паре не важен.*/

int[] arr = new int[10000];
int a = 1;
for (int i = 0; i < 10000; i++)
{
    arr[i] = a;
    ++a;
}

int c = 0;
int max = 0;

for (int i = 0; i < 9999; i++)
{
    for (int j = i + 1; j < 10000; j++)
    {
        int sum = (arr[i]) + (arr[j]);
        if (sum%60 == 0)
        {
            if (((arr[i])%40 == 0) || ((arr[j])%40 == 0))
            {
                c = ++c;
                if (max < sum) max = sum;
            }
        }        
    }    
}
Console.WriteLine(c +"   "+ max);
