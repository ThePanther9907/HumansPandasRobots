﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasRobots
{
    public class Human : IBeing
    {
        public void Eat()
        {
            var food = "Taco";
            Console.WriteLine($"Yum, I ate {food}");
        }
             
    }

   
}