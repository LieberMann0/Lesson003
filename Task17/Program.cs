// По двум заданным числам проверять является ли одно квадратом другого

int a = new Random().Next(1, 11);
Console.WriteLine(a);

int b = new Random().Next(1, 101);
Console.WriteLine(b);

int aSq = Convert.ToInt32(Math.Pow(a, 2));

if (aSq == b) Console.WriteLine("Второе число является квадратом первого.");
else Console.WriteLine("Второе число не является квадратом первого.");