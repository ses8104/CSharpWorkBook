using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<SportsBase> sports = new List<SportsBase>() { new SoccerClass(), new BaseballClass() };
            foreach (SportsBase sport in sports)
            {
                Console.WriteLine($"sport.GetSportsName={sport.GetSportsName()}"  );
            }

            Console.ReadKey();

        }
    }
}
