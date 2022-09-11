// 26. Возведите число А в натуральную степень B используя цикл

int pow(int a, int b)
{
    int pow = a;
    for (int i = 2; i <= b; i++)
    {
        pow *= a;
    }
    return pow;
}

System.Console.WriteLine(pow(2, 5));