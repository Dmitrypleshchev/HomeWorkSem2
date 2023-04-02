// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число");
string ss = "Это не день недели";
string check(int number)
{
if (number >5 && number < 7) ss = "Это выходной";
if (number >= 1 && number <=5) ss = "Это будний день";
return ss;
}
System.Console.WriteLine(check(number));