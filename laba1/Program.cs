// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Console.WriteLine("Завдання1");

        int number1 = 2;
        int number2 = 35;
        bool isDayValid = number1 >= 1 && number2 <= 31;
        bool isMonthValid = number2 >= 1 && number2 <= 12;

        bool isDateValid = isDayValid && isMonthValid;

        Console.WriteLine("Ці числа можуть бути днем та місяцем: " + isDateValid);


        Console.WriteLine("Завдання 2");

        double number = 25.54;
        int firstDigit = number1 / 10;
        int secondDigit = number1 % 10;

        int sum = firstDigit + secondDigit;

        Console.WriteLine($"Результат:{firstDigit}+{secondDigit} = {sum}");

        Console.WriteLine("Завдання 3");
        int h = 24;

        if (h >= 5 && h < 12)
        {
            Console.WriteLine("Добрий ранок");
        }
        else if (h >= 12 && h < 18)
        {
            Console.WriteLine("Добрий день");
        }
        else if (h >= 18 && h < 23)
        {
            Console.WriteLine("Доброї ночі");

        }
        else
        {
            Console.WriteLine("Доброї ночі");
        }
        Console.WriteLine("Завдання 4");
        Console.Write("number1 = ");
        int numb1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("number2 = ");
        int numb2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("number3 = ");
        int numb3 = Convert.ToInt32(Console.ReadLine());
        int max = Math.Max(Math.Max(numb1, numb2), numb3);
        int min = Math.Min(Math.Min(numb1, numb2), numb3);
        Console.WriteLine($"Максимальне значення: {max}");
        Console.WriteLine($"Мінімальне значення: {min}");

        Console.WriteLine("Завдання 5");
        Console.Write("length = ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.Write("width = ");
        double width = Convert.ToDouble(Console.ReadLine());
        double area = length * width;
        Console.WriteLine($"Площа прямокутника дорівнює: {area}");

        Console.WriteLine("Завдання 6");
        Console.Write("number = ");
        int numb = Convert.ToInt32(Console.ReadLine());
        if (numb % 2 == 0)
        {
            Console.WriteLine("Число є парним");
        }
        else
        {
            Console.WriteLine("Число не парне");
        }

        Console.WriteLine("Завдання 7");
        Console.Write("C = ");
        int C = Convert.ToInt32(Console.ReadLine());
        int F = (((9 * C) / 5) + 32);
        Console.WriteLine(F);

        Console.WriteLine("Завдання 8");
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        int suma = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Сума перших {n} натуральних чисел: {sum} ");
    }
    }

     