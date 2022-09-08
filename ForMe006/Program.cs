// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int numberTwo = new Random().Next(10, 100);
System.Console.WriteLine(numberTwo);
int firstNumber = numberTwo / 10;
int secondNumber = numberTwo % 10;
if(firstNumber > secondNumber) System.Console.WriteLine(firstNumber);
else System.Console.WriteLine(secondNumber);