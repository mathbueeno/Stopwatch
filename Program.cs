﻿using System;
using System.Threading;

namespace Stopwatch
{
    class program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            Console.ReadLine();


        }

        static void Start(int time)
        {

            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2500);
        }

    }

}


