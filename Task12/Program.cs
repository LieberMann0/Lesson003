// Удалить вторую цифру трёхзначного числа

int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int a = num%10;
num = num / 10;
int b = num - num%10;

int c = a + b;

Console.WriteLine(c);

/* Второй вариант
 
string a = Convert.ToString(num);
Console.WriteLine($"{a[0]}{a[2]}");  Эту строчку можно по-другому записать: Console.WriteLine(a[0] + "" + a[2]);
                                                                            Console.WriteLine("{0}{1}", a[0], a[2]);
*/
