Console.WriteLine("Программа выведет для вас все целые числа от -n до n, где n это вами введенное число. Так что вводите число, не стесняйтесь!");
int number = Convert.ToInt32(Console.ReadLine());
int minusNumber = - number;
while(minusNumber <= number)
{
    Console.WriteLine(minusNumber);
    minusNumber++;
}