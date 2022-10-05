// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Первый вариант
Console.WriteLine("Введите трехзначное число");
string input = Console.ReadLine();
double number = double.Parse(input);
if (number > 99 && number < 1000)
{
  double result = (number / 10 - number % 10/10) % 10;
  Console.WriteLine(result);
}
else
{
  Console.WriteLine("Это не трехзначное число");
}

// Второй вариант
Console.WriteLine("Введите трехзначное число");
string input1 = Console.ReadLine();
double number1 = double.Parse(input1);
if (number1 > 99 && number1 < 1000)
{
  Console.WriteLine(input1[1]);
}
else
{
  Console.WriteLine("Это не трехзначное число");
}
