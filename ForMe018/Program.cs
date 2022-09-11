// 27. Определить количество цифр в числе

int numberOfDigits(int number)
{
    int numberOfDigits = new int();
    while(number > 0)
    {
        number /= 10;
        numberOfDigits++;
    }
    return numberOfDigits;
}
System.Console.WriteLine(numberOfDigits(123));