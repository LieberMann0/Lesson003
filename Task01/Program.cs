//По двум заданным числам проверять является ли первое квадратом второго


double a;
double b;
string s;

Console.Write("Введите первое число:  ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

Console.Write("Введите второе число:  ");
s = Console.ReadLine();
b = Convert.ToInt32(s);

string ans = " ";

b = b * b;
if (a == b) ans = "Да";
else ans = "Нет";

Console.Write("Является первое число квадратом второго? - "+ans);