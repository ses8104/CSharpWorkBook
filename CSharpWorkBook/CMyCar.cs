using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkBook
{
    public partial class CMyCar : AKS
    {
        public override void Back() => Console.WriteLine("후진");
    }

    public partial class CMyCar : AKS
    {
        public void Right() => Console.WriteLine("우회전");
    }

    public sealed class CYourCar : CMyCar, IStandard
    {
        public void Run() => Console.WriteLine("전진");
    }
}
