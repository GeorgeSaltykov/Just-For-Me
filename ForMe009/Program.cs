// 14. Найти третью цифру числа или сообщить, что её нет

void thirdDigit(int number)
{
    int thirdDigit = new int();
    if(number > 99) 
    {
        while(number > 999) 
        {
            number /= 10;
        }
        thirdDigit = number % 10;
        System.Console.WriteLine($"Third digit is {thirdDigit}");
    }
    else System.Console.WriteLine("Your number doesn't have third digit. Sorry((");
}
System.Console.WriteLine("Please, enter a number. And i'll show you a third digit.");
thirdDigit(Convert.ToInt32(Console.ReadLine()));