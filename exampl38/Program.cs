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

Console.WriteLine("Введите максимальное число разрядов после запятой: ");
int Q = Convert.ToInt32(Console.ReadLine());

double[] array1 = new double[N];

for (int i = 0; i < N; i++)
{
    double rand1 = new Random().Next(Y, X);     //Генерация целой части  
    int St = Convert.ToInt32(Math.Pow(10, Q));
    double rand2 = new Random().Next(0, St);     //Генерация дробной части

    array1[i] = Math.Round(rand1+Math.Abs(rand2/Math.Pow(10, Q)), 3);
}


//вывод массива

Console.WriteLine();
Console.WriteLine("Полученный массив: ");
Console.WriteLine(string.Join(", ", array1));

//Поиск разницы между максимальным и минимальным элементов массива
double Min = X + 1;
double Max = Y - 1;

for (int i = 0; i < N; i++)
{
    if (array1[i] > Max) Max = array1[i];
    if (array1[i] < Min) Min = array1[i];
}

double result = Math.Round(Max - Min, 3);

Console.WriteLine();
Console.Write("Разница между максимальным и минимальным элементами массива: ");
Console.WriteLine(result);