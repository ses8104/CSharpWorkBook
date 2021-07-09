using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkBook
{
    public class CMethodOverride
    {
    }


    public class CParent
    {
        public void Say() => Console.WriteLine("부모님 안녕하세요");
        public void Run() => Console.WriteLine("부모님 달리기한다.");
        public virtual void Walk() => Console.WriteLine("부모님 걷다");
    }

    public class CChild : CParent
    {
        public void Say() => Console.WriteLine("자녀 안녕하세요");
        public new void Run() => Console.WriteLine("자녀 달리다");
        public override void Walk() => Console.WriteLine("자녀 걷다");

    }
}
