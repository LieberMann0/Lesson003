// Дано число. Проверить кратно ли оно 7 и 23

int a = new Random().Next(7, 2001);
Console.WriteLine(a);
if ((a%7 == 0) && (a%23 == 0)) Console.WriteLine("Число кратно 7 и 23.");
if ((a%7 == 0) && (a%23 > 0)) Console.WriteLine("Число кратно только 7.");
if ((a%7 > 0) && (a%23 == 0)) Console.WriteLine("Число кратно только 23.");
if ((a%7 > 0) && (a%23 > 0)) Console.WriteLine("Число не кратно данным числам");