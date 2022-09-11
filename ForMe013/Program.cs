// 22. Найти расстояние между точками в пространстве 2D/3D

double distanceBetweenPoints(int[] firstPoint, int[] secondPoint)
{
    int[] halfResult = new int[firstPoint.Length];
    for (int i = 0; i < firstPoint.Length; i++)
    {
        halfResult[i] = secondPoint[i] - firstPoint[i];
    }
    for (int j = 0; j < halfResult.Length; j++)
    {
        halfResult[j] = halfResult[j] * halfResult[j];
    }
    double result = new double();
    for (int k = 0; k < halfResult.Length; k++)
    {
        result += Convert.ToDouble(halfResult[k]);
    }
    return Math.Sqrt(result);
}
int[] first = { 4, 4, 5 };
int[] second = { 6, 6, 7 };
System.Console.WriteLine(distanceBetweenPoints(first, second));