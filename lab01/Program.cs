﻿using System;

namespace lab01
{
    public class Program
    {
        static public int Example(int n)
        {
            int m = n/60;
            Console.WriteLine("Минуло" + " " + m.ToString() + " хвилин(а)" + " вiд початку доби");
            return m;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть кiлькiсть секунд якi пройшли вiд початку доби");
            string S1 = Console.ReadLine();
            int n = int.Parse(S1);
            Example(n);
            Console.ReadLine();
        }
    }
}
