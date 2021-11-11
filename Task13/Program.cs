// Выяснить, кратно ли число заданному, если нет, вывести остаток.

int a = 13;
int b = new Random().Next(1, 1001);
Console.WriteLine(b);
Console.WriteLine("Кратно ли данное число, числу 13?");
int result = b%13;
if (b%13 == 0) Console.WriteLine("Да.");
else Console.WriteLine("Нет.  Остаток - "+b%13);