// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.


int[] array = new int[8];
Output(array);


void Output(int[] col)
{
    Console.WriteLine("Введите массив");
    int N = col.Length;
    for (int i = 0; i < N; i++) 
    {
        col[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("\nМассив: {0}",String.Join(" ",col));
}
