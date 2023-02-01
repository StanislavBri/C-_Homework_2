// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//  645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Random rnd = new Random();
int a = rnd.Next();
//int a = rnd.Next(0, 99);

Console.WriteLine(a);
int ostatok = 0;
if (Math.Abs(a) > 99) 
{
    while (a > 1000)
    {
        a = Math.Abs(a) / 10;
    }
    ostatok = a % 10;
    Console.WriteLine(ostatok);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}