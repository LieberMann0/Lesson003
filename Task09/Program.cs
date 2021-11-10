// Показать последнюю цифру трёхзначного числа


Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = a%10;
Console.Write(result);