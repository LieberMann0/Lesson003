// Показать вторую цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

a = a / 10;
Console.Write(a%10);
