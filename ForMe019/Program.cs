// 29. Написать программу вычисления произведения чисел от 1 до N

int result = 1;
int multiply(int i, int n)
{
    if (i <= n)
    {
        result *= i;
        multiply(i + 1, n);
    }
    return result;
}
System.Console.WriteLine(multiply(1, 7));