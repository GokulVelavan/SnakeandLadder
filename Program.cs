﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackandLadder
{
    class Program
    {

        static void Main(string[] args)
        {
            int POSITION = 0;
            int PLAYER = 1;
            int DICE = 0;
            int COUNT = 0;
            Random random = new Random();
            DICE = random.Next(0, 7);
            Console.WriteLine("THE STARTING POSITION IS:{0}", COUNT);
            Console.WriteLine("THE STARTING DICE NO IS:{0}", DICE);

            Console.ReadLine();
        }
    }
}