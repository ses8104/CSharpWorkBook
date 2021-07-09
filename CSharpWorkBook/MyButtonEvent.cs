using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpWorkBook
{
    // 클래스 내의 이벤트 정의
    class MyButtonEvent
    {
        public string Text;    // 이벤트 정의
        
        public event EventHandler Click; 
        
        public void MouseButtonDown()
        {
            if (this.Click != null)
            {          // 이벤트핸들러들을 호출
                Click(this, EventArgs.Empty);
            }
        }

        public void Run()
        {
            MyButtonEvent btn = new MyButtonEvent();

            btn.Click += new EventHandler(btn_Click);

            btn.Text = "Run";
        }

        void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button click");
        }
    }



}
