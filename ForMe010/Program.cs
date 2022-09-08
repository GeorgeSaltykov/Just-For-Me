// Дано число. Проверить кратно ли оно 7 и 23

void muliplicity(int number)
{
    if(number % 7 == 0 && number % 23 == 0) System.Console.WriteLine("Yey!! You did it! You found that number");
    else System.Console.WriteLine("Sry, but your number doesn't");
}
muliplicity(Convert.ToInt32(Console.ReadLine()));