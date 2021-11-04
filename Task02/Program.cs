//Даны два числа. Показать большее и меньшее число

int a;
int b;
string s;

Console.Write("Введите первое число:  ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

Console.Write("Введите второе число:  ");
s = Console.ReadLine();
b = Convert.ToInt32(s);

if (a > b)
    {
    Console.WriteLine("Большее число "+a);
    Console.WriteLine("Меньшее число "+b);
    }
else
    {
     Console.WriteLine("Большее число "+b);
     Console.WriteLine("Меньшее число "+a);
    }