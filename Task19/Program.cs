// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0


int GetCoordNumber(double x, double Y)
{
    if (x > 0 & Y > 0) return 1;
    if (x < 0 & Y > 0) return 2;
    if (x > 0 & Y < 0) return 3;
    if (x < 0 & Y < 0) return 4;
}

GetCoordNumber(x, Y);
Console.WriteLine("Четверть №:"+GetCoordNumber(x, Y));