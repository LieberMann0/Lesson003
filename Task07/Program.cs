//  Показать числа от -N до N

Console.Write("Введите отрицательное число: ");
int neg = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите положительное число: ");
int pos = Convert.ToInt32(Console.ReadLine());

int count = (pos - (neg)) +1;

for(int i = 0; i < count; i++, neg++)
{
    Console.Write((neg)+"  ");
}