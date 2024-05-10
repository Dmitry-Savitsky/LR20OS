using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите четыре вещественных числа:");

        Console.Write("Число 1: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Число 2: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Число 3: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Число 4: ");
        double num4 = Convert.ToDouble(Console.ReadLine());

        double sum = 0;
        if (num1 > 5)
            sum += num1;
        if (num2 > 5)
            sum += num2;
        if (num3 > 5)
            sum += num3;
        if (num4 > 5)
            sum += num4;

        Console.WriteLine($"Сумма чисел больших пяти: {sum}");

        Console.ReadLine();
    }
}
