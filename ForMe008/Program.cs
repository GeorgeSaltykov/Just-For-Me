// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток

void muliplicity(int firstNumber, int secondNumber)
{
    if(firstNumber % secondNumber == 0) System.Console.WriteLine("Yey!!!");
    else System.Console.WriteLine($"Nope. The remainder of the division is {firstNumber % secondNumber}");
}
muliplicity(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));