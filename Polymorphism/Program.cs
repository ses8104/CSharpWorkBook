using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.animalSound();

            animal = new Eagle();
            animal.animalSound();

            Console.ReadKey();
        }
    }
}
