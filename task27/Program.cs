// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


using System;

namespace task25
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = WorkWithUser("Введите число : ");
            int result = Sum(number);
            Console.WriteLine(result);
        }

        static string WorkWithUser(string msg)
        {
            Console.Write(msg);
            string number1 = Console.ReadLine();
            return number1;
        }

        static int Sum(string number1)
        {
            int summa = 0;
            for (int i = 0; i < number1.Length; i++)
            {
                summa += int.Parse(number1[i].ToString());
            }

            return summa;
        }
    }
}