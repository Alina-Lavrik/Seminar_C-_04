/* Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

4  -> 24
5  -> 120
*/

Console.WriteLine("Введи число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение чисел от 1 до {N} равно {Sum(N)}");

int Sum(int number)
{
    int sum = 1;
    for (int i = 1; i <= N; i++)
    {
        sum = i * sum;
    }
    return sum;
}

