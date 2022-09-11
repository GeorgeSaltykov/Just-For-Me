// 45. Показать числа Фибоначчи
// n3 = n2 - n1
// n1 + n2 = n3
// 1 1 2 3 5 8 13 21 34 55 89

int[] Fibonachi(int n)
{
    int[] Fibonachi = new int[n];
    for (int i = 0; i < Fibonachi.Length; i++)
    {
        if (i <= 1) Fibonachi[i] = 1;
        else if (i > 1) Fibonachi[i] = Fibonachi[i - 1] + Fibonachi[i - 2];
    }
    return Fibonachi;
}

void printFibonachi(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        System.Console.Write($"{array[j]} ");
    }
}
printFibonachi(Fibonachi(20));