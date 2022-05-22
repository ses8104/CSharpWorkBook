using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingMorning
{
    internal class GreetingMorningClass : IGreeting
    {
        public string GetMessage()
        {
            return "좋은아침 입니다.";
            //throw new NotImplementedException();
        }
    }
    internal class GreetingAfternoonClass : IGreeting
    {
        public string GetMessage()
        {
            return "좋은점심 입니다.";
            //throw new NotImplementedException();
        }
    }
    internal class GreetingEvningClass : IGreeting
    {
        public string GetMessage()
        {
            return "좋은저녁 입니다.";
            //throw new NotImplementedException();
        }
    }
}
