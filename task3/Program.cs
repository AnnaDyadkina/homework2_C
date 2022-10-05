// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
//Console.WriteLine("Hello, World!");
string input = Console.ReadLine();
int number = int.Parse(input);
if (number >= 1 && number <= 5 )
{
    Console.WriteLine("Рабочий день");
}
else if (number == 6 || number == 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Введите число от 1 до 7");
}
