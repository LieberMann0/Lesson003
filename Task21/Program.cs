// Программа проверяет пятизначное число на палиндром.

string a = Convert.ToString(new Random().Next(10000, 100000));
Console.WriteLine(a);
if ((a[0] == a[4]) && (a[1] == a[3])) Console.WriteLine("ПАЛИНДРОМ!");
else Console.WriteLine("Не палиндром");