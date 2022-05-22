using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingMorning
{
    internal class GreetingMornig : GreetingBase
    {
        public override string GetMessage()
        {
            return "Good morning";

        }
    }

    public class GreetingAfternoon : GreetingBase
    {
        public override string GetMessage()
        { 
            return "Good Afternoon";
        }
    }

    public class GreetingEvening : GreetingBase
    {
        public override string GetMessage()
        {
            return "Good night";
        }
    }
}
