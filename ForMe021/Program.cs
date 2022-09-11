// 41. Выяснить являются ли три числа сторонами треугольника 

void triangle(int x, int y, int z)
{
    if (x + y > z 
            && z + x > y 
                && y + z > x) 
        System.Console.WriteLine("It is triangle");
    else System.Console.WriteLine("It isn't triangle");
}
triangle(2, 3, 2);