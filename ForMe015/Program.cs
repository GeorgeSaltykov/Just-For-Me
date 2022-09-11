// 24. Найти кубы чисел от 1 до N

double[] cubesOfNumbers(int n)
{
    double[] cubesOfNumbers = new double[n];
    for (int i = 0; i < cubesOfNumbers.Length; i++)
    {
        cubesOfNumbers[i] = Math.Pow(i + 1, 3);
    }
    return cubesOfNumbers;
}
void printArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
printArray(cubesOfNumbers(number));