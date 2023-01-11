// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


void Exponentiation(int x, int y)
{
    int proi = 1;
    for (int i = 0; i < y; i++)
    {
        proi =proi * x;
    }
    Console.WriteLine(proi);
}


Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());

Exponentiation(A, B);
