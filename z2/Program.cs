using System;

namespace z2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double res = 0;
            Console.WriteLine("Какое действие выполнить?\r\n" +
                "1. Сложение\r\n" +
                "2. Вычитание\r\n" +
                "3. Умножение\r\n" +
                "4. Деление\r\n" +
                "5. Нахождение остатка");
            int dev = Convert.ToInt32(Console.ReadLine());
            if (dev == 1)
            {
                res = a + b;
                Console.WriteLine((a) + " + " + (b) + " = " + (res));
            } else if (dev == 2)
            {
                res = a - b;
                Console.WriteLine((a) + " - " + (b) + " = " + (res));
            } else if (dev == 3)
            {
                res = a * b;
                Console.WriteLine((a) + " * " + (b) + " = " + (res));
            } else if (dev == 4) {
                res = a / b;
                Console.WriteLine((a) + " / " + (b) + " = " + (res));
            } else if (dev == 5)
            {
                res = a % b;
                Console.WriteLine((a) + " % " + (b) + " = " + (res));
            }
        }
    }
}