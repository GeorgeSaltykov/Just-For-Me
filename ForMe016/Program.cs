// 25. Найти сумму чисел от 1 до А

int result = new int();
int sumOfNumbers(int i, int a)
{
    if(i <= a) 
    {
        result += i;
        sumOfNumbers(i + 1, a);
    }
    return result;
}
System.Console.WriteLine(sumOfNumbers(1, 7));