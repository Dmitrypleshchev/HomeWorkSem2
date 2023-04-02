// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if (number>=100 && number < 1000)
{
  int Mid = (number%100 - number%10)/10;
  Console.WriteLine($"Вторая цифра числа {number} является {Mid}");
}
else 
Console.WriteLine("Это число не трехзначное");


