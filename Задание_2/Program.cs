using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());

        int sum = 0;

        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        Console.WriteLine("Сумма цифр в числе: " + sum);
    }
}
