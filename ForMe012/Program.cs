// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int whereIsPoint(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    else if(x < 0 && y > 0) return 2;
    else if(x < 0 && y < 0) return 3;
    else if(x > 0 && y < 0) return 4;
    else return 0;

}
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Point on {whereIsPoint(x, y)}");
