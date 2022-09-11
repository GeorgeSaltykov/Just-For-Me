// 23. Показать таблицу квадратов чисел от 1 до N 

int[] squaresOfNumbers(int n)
{
    int[] squaresOfNumbers = new int[n];
    for (int i = 0; i < n; i++)
    {
        squaresOfNumbers[i] = (i + 1) * (i + 1);
    }
    return squaresOfNumbers;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}
printArray(squaresOfNumbers(5));