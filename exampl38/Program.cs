/*
Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

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

//Поиск разницу между максимальным и минимальным элементов массива
int Min = X + 1;
int Max = Y - 1;

for (int i = 0; i < N; i++)
{
    if (array1[i] > Max) Max = array1[i];
    if (array1[i] < Min) Min = array1[i];
}

int result = Max - Min;

Console.WriteLine();
Console.Write("Разница между максимальным и минимальным элементами массива: ");
Console.WriteLine(result);