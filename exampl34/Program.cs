/*
Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

//ввод массива из случайных чисел

Console.WriteLine("Введите число элементов массива");
int N = Convert.ToInt32(Console.ReadLine());

//Максимальное значение элементов массива
int X = 1000;

int[] array1 = new int[N];
for (int i = 0; i < N; i++)
{
    array1[i] = new Random().Next(1, X);
}

//вывод массива

Console.WriteLine();
Console.WriteLine("Полученный массив: ");
Console.WriteLine(string.Join(", ", array1));

//Количество чётных чисел в массиве
int num = 0;

for (int i = 0; i < N; i++)
{
    if (array1[i] % 2 == 0) num++;
}

Console.WriteLine();
Console.Write("Количество четных чисел в массиве: ");
Console.WriteLine(num);