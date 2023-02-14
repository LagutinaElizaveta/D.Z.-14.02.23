// Проверка дня недели
Console.WriteLine("Введите цифру, обозначающую день недели");
int a = int.Parse(Console.ReadLine());
if (a < 1 || a > 7)
{
    Console.WriteLine("Такого дня недели не существует. Введите корректную цифру");
    return;
}
if (a >= 1 && a <= 5) Console.WriteLine("Рабочий день");
if (a >= 6) Console.WriteLine("Выходной день");
