﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Eagle : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("끼룩끼룩");
        }
    }
}
