// Найти третью цифру числа или сообщить, что её нет

int num = new Random().Next(1, 100001);
Console.WriteLine(num);
if (num < 100) Console.WriteLine("Третьей цифры нет.");
else
{
string n = Convert.ToString(num);
Console.WriteLine("Третья цифра равна - "+(n[2]));
}