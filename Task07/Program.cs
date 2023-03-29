Console.WriteLine("Введите трехзначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>=100 && number<=999)
{
int lastNumber = number %10;
Console.WriteLine($"Последняя цифра числа: {lastNumber}");
}
else {
Console.WriteLine($" {number} число не трехзначное ");
}