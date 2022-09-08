// Удалить вторую цифру трёхзначного числа

int number = Convert.ToInt32(Console.ReadLine());
string withoutSecond = string.Empty;
withoutSecond = Convert.ToString(number / 100) + Convert.ToString(number % 10);
int result = Convert.ToInt32(withoutSecond);
System.Console.WriteLine(result);