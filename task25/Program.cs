// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


using System;

namespace task25
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = WorkWithUser("Введите число А: ");
            int number2 = WorkWithUser("Введите число B: ");

            int result = Degree(number1, number2);
            Console.WriteLine(result);
        }

        static int WorkWithUser(string msg)
        {
            Console.Write(msg);
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        static int Degree(int num1, int num2)
        {
            int deg = (int)Math.Pow(num1, num2);
            return deg;
        }
    }
}
