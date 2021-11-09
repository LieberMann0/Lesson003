// Написать программу вычисления значения функции y=f(a)

int F(int a)
{
    int y = a;
    return y;
}

Console.Write("Введите значение a -  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int result = F(a);
Console.WriteLine("y = "+result);
