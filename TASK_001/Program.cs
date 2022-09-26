// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введи число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {A} равна {GetSum(A)}");

int GetSum(int limit)
{
    int sum = 0;
    for(int i=1; i <= limit; i++)
    {
        sum = sum + i;
    }
    return sum;
}
