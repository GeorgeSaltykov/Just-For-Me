// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

int[] x = new int[4];
int[] y = new int[4];

fillArray(x);
printArray(x);
System.Console.WriteLine();
fillArray(y);
printArray(y);
System.Console.WriteLine();
printArray(disjunction(x, y));
System.Console.WriteLine();
printArray(inversion(disjunction(x, y)));
System.Console.WriteLine();
printArray(inversion(x));
System.Console.WriteLine();
printArray(inversion(y));
System.Console.WriteLine();
printArray(conjunction(inversion(x), inversion(y)));
System.Console.WriteLine();
System.Console.WriteLine(truthfulness(inversion(disjunction(x, y)), conjunction(inversion(x), inversion(y))));

void fillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

int[] disjunction(int[] x, int[] y)
{
    int[] disjunction = new int[x.Length];
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] == 1 || y[i] == 1) disjunction[i] = 1;
        else disjunction[i] = 0;
    }
    return disjunction;
}

int[] inversion(int[] x)
{
    int[] inversion = new int[x.Length];
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] == 0) inversion[i] = 1;
        else inversion[i] = 0;
    }
    return inversion;
}

int[] conjunction(int[] x, int[] y)
{
    int[] conjunction = new int[x.Length];
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] == 1 && y[i] == 1) conjunction[i] = 1;
        else conjunction[i] = 0;
    }
    return conjunction;
}

bool truthfulness(int[] x, int[] y)
{
    bool result = new bool();
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] == y[i]) result = true;
        else result = false;
    }
    return result;
}