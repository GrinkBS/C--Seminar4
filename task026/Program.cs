// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Не используем в решении задачи строки и ее свойства

Console.Write("Введите число : ");
int N = Convert.ToInt32(Console.ReadLine());

int count = 0;

for (count = 0; N > 0; count++)
{
    N = N / 10;
}
Console.WriteLine($"Количество цифр в числе = {count}");