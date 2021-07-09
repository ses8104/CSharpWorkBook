using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkBook
{
    public abstract class AKS
    {
        public abstract void Back();
        public void Left() => Console.WriteLine("좌회전");
    }
}
