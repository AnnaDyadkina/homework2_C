// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
//Console.WriteLine("Hello, World!");
string input = Console.ReadLine();
double number = double.Parse(input);
number = Math.Abs(number);
input = number.ToString();
if (input.Length >= 3)
{
  Console.WriteLine(input[2]);
}
else
{
  Console.WriteLine("Нет третьей цифры");
}
