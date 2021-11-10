// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int num = new Random().Next(10, 100);
Console.WriteLine(num);

int a = num%10;
int b = num / 10;

int max;

if (a > b) max = a;
else max = b;

Console.WriteLine("Наибольшая цифра: "+max);
