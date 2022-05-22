using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingMorning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var greetings = new List<GreetingBase>() { new GreetingMornig(), new GreetingAfternoon(), new GreetingEvening() };

            foreach (var item in greetings)
            {
                Console.WriteLine($"item.GetMessage = {item.GetMessage()}");
            }

            var igreetings = new List<IGreeting>() { new GreetingMorningClass(), new GreetingAfternoonClass(), new GreetingEvningClass() };

            foreach (var item in igreetings)
            {
                Console.WriteLine($"IGreeting.GetMessage = {item.GetMessage()}");
            }

            Console.ReadKey();
        }
    }
}
