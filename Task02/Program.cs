//Даны два числа. Показать большее и меньшее число

Console.Write("Введите первое число:  ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:  ");
int b = Convert.ToInt32(Console.ReadLine());;

if (a > b)
    {
    Console.WriteLine("Большее число "+a);
    Console.WriteLine("Меньшее число "+b);
    }
if (a < b)
    {
     Console.WriteLine("Большее число "+b);
     Console.WriteLine("Меньшее число "+a);
    }