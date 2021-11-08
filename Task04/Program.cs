//Найти максимальное из трех чисел

int NumA = new Random().Next(-1000, 1000);
Console.WriteLine(NumA);
int NumB = new Random().Next(-1000, 1000);
Console.WriteLine(NumB);
int NumC = new Random().Next(-1000, 1000);
Console.WriteLine(NumC);

int max = NumA;

if (NumB > max) max = NumB;
if (NumC > max) max = NumC;

Console.WriteLine();
Console.WriteLine("Максимальное число "+max);
