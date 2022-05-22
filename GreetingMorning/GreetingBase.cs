using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingMorning
{
    public abstract class GreetingBase
    {
        public virtual string GetMessage()
        {
            return "";
        }
    }
}
