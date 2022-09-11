// 35. Определить, присутствует ли в заданном массиве, некоторое число 

int[] array = {1, 3, 6, 4, 3, 8, 3, 3};

void findNumber(int[] array, int number)
{
    int count = new int();
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == number) 
        {
        count++;
        }
    }
    if(count == 0) System.Console.WriteLine($"Sorry, we didn't find {number} in array");
    else System.Console.WriteLine($"Yes, we found it. We have found {number} in the array for {count} times.");
}
findNumber(array, 10);
