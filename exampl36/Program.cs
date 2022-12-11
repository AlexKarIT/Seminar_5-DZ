/*
Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

*/

//ввод массива из случайных чисел

Console.WriteLine("Введите число элементов массива");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное значение элементов массива: Y...");
int Y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное значение элементов массива: " + Y + "...X");
int X = Convert.ToInt32(Console.ReadLine());

int[] array1 = new int[N];
for (int i = 0; i < N; i++)
{
    array1[i] = new Random().Next(Y, X);
}

//вывод массива

Console.WriteLine();
Console.WriteLine("Полученный массив: ");
Console.WriteLine(string.Join(", ", array1));

//Сумма элементов, стоящих на нечётных позициях
int sum = 0;

for (int i = 0; i < N; i++)
{
    if (i % 2 == 1) sum += array1[i];
}

Console.WriteLine();
Console.Write("Сумма элементов, стоящих на нечётных позициях: ");
Console.WriteLine(sum);