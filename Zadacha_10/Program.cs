// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
bool isnumber = int.TryParse(Console.ReadLine(), out int a);

if ((isnumber) && (a < 1000))
{
    int b = a / 10;
    int ostatok = Math.Abs(b % 10);
    Console.WriteLine(ostatok);
}
else
{
    Console.WriteLine("Некорректный ввод");
}