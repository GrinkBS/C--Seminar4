// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


// Реш 1. Принимаем на ввод.

Console.Write("Введите элемент 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите элемент 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите элемент 3: ");
int n3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите элемент 4: ");
int n4 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите элемент 5: ");
int n5 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите элемент 6: ");
int n6 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите элемент 7: ");
int n7 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите элемент 8: ");
int n8 = Convert.ToInt32(Console.ReadLine());

int[] array = { n1, n2, n3, n4, n5, n6, n7, n8};

Console.WriteLine(string.Join(", ", array));


//Реш 2. Рандомно до 99

// int[] arr = new int[8];
// Random rand = new Random();
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = rand.Next(0, 99);
// }

Console.WriteLine(string.Join(", ", array));