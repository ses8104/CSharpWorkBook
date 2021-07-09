using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkBook
{
    public class CDelegate
    {
        delegate void MyDelegate();
        delegate int AddDelegate(int a, int b);

        int num = 100;
        double aa = 11.11;

        public CDelegate()
        {
            MyDelegate myDelegate;
            myDelegate = FuncTest;
            myDelegate();

            AddDelegate addDelegate = Add;
            Console.WriteLine(addDelegate(1, 2).ToString());
        }

        public void FuncTest()
        {

        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    public class CExDelegate
    {

        public delegate int MyDeletgate();

        public CExDelegate()
        {

        }

        public int fnSendData()
        {
            return 1;
        }

    }

}
