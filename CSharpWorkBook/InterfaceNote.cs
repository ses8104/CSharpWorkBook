using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkBook
{
    public class InterfaceNote : ICar
    {
        public void Go() => Console.WriteLine("상속한 인터페이스에 정의된 모든 멤버를 반드시 구현해야한다.");
    }
    public interface ICar
    {
        void Go();
    }

}
