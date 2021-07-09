using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkBook
{
    public class CPet : IDog, ICat
    {
        void IDog.Eat() => Console.WriteLine("Dog : Eat");
        void ICat.Eat() => Console.WriteLine("Cat : Eat");
    }
}
