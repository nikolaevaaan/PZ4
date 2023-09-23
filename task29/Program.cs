// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using System;

namespace task29
{
     class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[8];
            FullArray(mass);
            Array(mass);            
        }

         static void FullArray(int[] array)
        {
           for(int i = 0; i < array.Length; i++){
            array[i] = new Random().Next(0,10);
           }
         }

        static void Array(int[] arr)
        {
            Console.WriteLine("[" + string.Join(", ", arr) + "]");             
        }
    }
}
