// Показ второй цифры трехзначного числа, введенного пользователем
Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
if (num >= 100 && num < 1000)
{

    Console.WriteLine($"Вторая цифра введенного числа {num / 10 % 10}");
}
else
{
    Console.WriteLine("Число не является трехзначным. Введите трехзначное число");
}

