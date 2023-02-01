// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели от 1 до 7");
bool isnumber = int.TryParse(Console.ReadLine(), out int a);

if ((isnumber) && (a < 8) && (a > 1))
{
    if ((a == 6) || (a == 7))
    {
        Console.WriteLine("да");
    }
    else 
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("Некорректный ввод");
}