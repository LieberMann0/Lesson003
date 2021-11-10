// Показать четные числа от 1 до N

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int count = a;

int result = 1;

for(int i = 0; i < count; i++, result++)
{
    if (result%2 == 0)
    Console.Write((result)+"  ");
}