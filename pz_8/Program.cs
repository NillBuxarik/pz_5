﻿using System;

namespace pr_8

{

    class Program

    {

        static void Main(string[] args)

        {

            Random rand = new Random();
            const int size = 10;//размер массива
            const int a = -100;
            const int d = 100;
            int counter = 0;
            int[] arr = new int[size];
            Console.WriteLine("Массив:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(a, d);
                if (arr[i] < 0)
                    counter++;
                Console.WriteLine((i + 1) + ") " + arr[i]);
            }
            Console.WriteLine("n/Количество отрицательных элементов: " + counter);
            Console.ReadKey();// как вывести все отрицательные числа в порядке возростания
        }
    }
}