// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, 
// минимальный элемент и его индекс, среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями.
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.


void Run(int[] col)
{
    for (int index = 0; index < col.Length; index++)
    {
        col[index] = new Random().Next(1, 10);
    }
}

void Print(int[] col2)
{
    foreach (int item in col2)
        Console.Write(item + " ");
    Console.WriteLine();
}

void PrintMaxMinArithmetic(int[] col3)
{
    int max = col3[0];
    int maxindex = 0;
    int min = col3[0];
    int minindex = 0;
    double pr = col3.Average();

    for (int index3 = 0; index3 < col3.Length; index3++)
    {
        if (col3[index3] > max) 
        {
            max = col3[index3];
            maxindex = index3;
        }
        else if (col3[index3] < min) 
        {
            min = col3[index3];
            minindex = index3;
        }
    }
    Console.WriteLine($"Максимальное число = {max}, его индекс = {maxindex}. Минимальное число = {min}, его индекс = {minindex}. Среднее арифметическое = {pr}");
}

void Selection(int[] col4)
{
    for (int i = 0; i < col4.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < col4.Length; j++)
        {
            if (col4[j] < col4[minPosition]) minPosition = j;
        }
        int x = col4[i];
        col4[i] = col4[minPosition];
        col4[minPosition] = x;
    }
}

void Mediana(int[] col5)
{
    int length = col5.Length;
    if (col5.Length % 2 == 0)
    {
        int length2 = length / 2;
        int length3 = length2 - 1;
        Console.WriteLine($"Медианное значение = {col5[length2]} и {col5[length3]}");
    }
    else 
    {
        int length4 = length / 2;
        // double y = Math.Ceiling(length4 / 2);
        Console.WriteLine($"Медианное значение = {col5[length4]}");   
    }
}



Console.WriteLine("Задайте мерность массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];

Run(array);
Console.WriteLine();

Print(array);
PrintMaxMinArithmetic(array);
Console.WriteLine();

Selection(array);
Print(array);
Mediana(array);






// int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
 
// int min = numbers.Min();
// int max = numbers.Max();
// double average = numbers.Average();
 
// Console.WriteLine($"Min: {min}");           // Min: 1
// Console.WriteLine($"Max: {max}");           // Max: 88
// Console.WriteLine($"Average: {average}");   // Average: 34