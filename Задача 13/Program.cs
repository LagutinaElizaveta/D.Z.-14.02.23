// Третья цифра заданного числа или "третьей цифры нет"
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if (a < 100)
{
    Console.WriteLine("Во введенном числе нет третьей цифры");
    return;
}
while (a > 999)
{
    a = a / 10;                                                       // a /=10;
}
Console.WriteLine($"Третья цифра  -  {a % 10}");