using System;

namespace CSharpWorkBook
{
    public class ButtonClass
    {
        public delegate void EventHandler();
        public event EventHandler click;

        public void OnClick()
        {
            if (click != null)
            {
                click();
            }
        }
    }

    public class CEvent
    {
        public CEvent()
        { 
            ButtonClass btn = new ButtonClass();

            btn.click += Hi1;
            btn.click += Hi2;
            btn.OnClick();
        }

        public void Hi1()
        {
            Console.WriteLine("C#");
        }

        public void Hi2()
        {
            Console.WriteLine(".NET");
        }
    }

}