/*
Задача 37 со звездочкой, дополнительная: 
Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

//ввод массива из случайных чисел

Console.WriteLine("Введите число элементов массива");
int N = Convert.ToInt32(Console.ReadLine());

//Максимальное значение элементов массива
int X = 10;

int[] array1 = new int[N];
for (int i = 0; i < N; i++)
{
    array1[i] = new Random().Next(1, X);
}

//вывод массива

Console.WriteLine();
Console.WriteLine("Полученный массив: ");
Console.WriteLine(string.Join(", ", array1));

//Получение размера нового массива
int L = N / 2 + N % 2;

//Получение нового массива из произведений пар
int[] array2 = new int[L];

for (int j = 0; j < L - N % 2; j++)
{
    array2[j] = array1[j] * array1[N - j - 1];
}

if (N % 2 == 1) array2[L-1] = array1[L-1];

//вывод массива

Console.WriteLine();
Console.WriteLine("Массив пар: ");
Console.WriteLine(string.Join(", ", array2));