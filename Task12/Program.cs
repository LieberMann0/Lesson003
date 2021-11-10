// Удалить вторую цифру трёхзначного числа

int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int a = num%10;
num = num / 10;
int b = num - num%10;

int c = a + b;

Console.WriteLine(c);