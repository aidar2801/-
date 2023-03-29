Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine($"Ураа число {number1} является квадратом числа {number2}");
}
else
{
    Console.WriteLine($"па па пам {number1} не является квадратом числа {number2}");
}