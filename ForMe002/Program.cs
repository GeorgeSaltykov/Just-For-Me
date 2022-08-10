Console.WriteLine("Программа, которая напомнит вам названия дней английской недели. Введите число от 1 до 7.");
int numberOfTheDay = Convert.ToInt32(Console.ReadLine());
if(numberOfTheDay == 1)
{
    Console.WriteLine("It is Sunday");
}
else if(numberOfTheDay == 2)
{
    Console.WriteLine("It is Monday");
}
else if(numberOfTheDay == 3)
{
    Console.WriteLine("It is Tuesday");
}
else if(numberOfTheDay == 4)
{
    Console.WriteLine("It is Wednsday");
}
else if(numberOfTheDay == 5)
{
    Console.WriteLine("It is Thursday");
}
else if(numberOfTheDay == 6)
{
    Console.WriteLine("It is Friday");
}
else if(numberOfTheDay == 7)
{
    Console.WriteLine("It is Saturday");
}
else
{
    Console.WriteLine("Yours number is out of range. Try again range is 1 to 7");
}