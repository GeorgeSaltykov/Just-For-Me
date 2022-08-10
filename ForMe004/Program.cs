Console.WriteLine("Введите трехзначное число и я покажу вам его последнее. УУУУ, магия!!!");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
int lastNumber = threeDigitNumber % 10;
Console.WriteLine(lastNumber);