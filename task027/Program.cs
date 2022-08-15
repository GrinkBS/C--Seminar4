// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число : ");
int N = Convert.ToInt32(Console.ReadLine());
int n1 = N;
int count = 0;
for (count = 0; N > 0; count++)
{
    N = N / 10;
}

int length = count;
int sum = 0;

string numberText = Convert.ToString(n1);


for (int i = 0; i <= length - 1; i++)
{
    sum = sum + numberText[i]-'0';
}
Console.WriteLine($"Сумма цифр в числе = {sum}");
