//По двум заданным числам проверять является ли первое квадратом второго


Console.Write("Введите первое число:  ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число:  ");
double b = Convert.ToDouble(Console.ReadLine());

string ans = " ";

b = Math.Pow(b, 2);
if (a == b) ans = "Да";
else ans = "Нет";

Console.Write("Является ли первое число квадратом второго? - "+ans);
