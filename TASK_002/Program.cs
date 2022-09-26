/* Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5  */


Console.WriteLine("Введи число N: ");
string N = Console.ReadLine()!;
Console.WriteLine($"Количество цифр в числе {N} равно {Counter(N)}");

int Counter(string number)
{
    int sum = 0;
    for(int i=1; i <= N.Length; i++)
    {
        sum = i;
    }
    return sum;
}
