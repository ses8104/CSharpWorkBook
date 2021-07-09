using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkBook
{
    public class Parent
    {
        public virtual void A()
        {
            Console.WriteLine("부모 클래스의 A() 메소드 호출!");
        }
    }

    public class Child : Parent
    {
        public override void A()
        {
            Console.WriteLine("자식 클래스(Childe)의 A() 메소드 호출!");
        }
    }
    public class Daughter : Parent
    {
        public override void A()
        {
            Console.WriteLine("자식 클래스의(Daughter)의 A() 메서드 호출!");
        }
    }


    public class ClassInheritance
    {
        public int num = 10;

        public ClassInheritance()
        {
            Console.WriteLine("부모 클래스의 생성자가 호출되었습니다.");
        }
    }

    public class ClassInheritance_child : ClassInheritance
    {
        public int num;
        public ClassInheritance_child(int num)
        {
            this.num = num;

            Console.WriteLine("자식 클래스의 생성자가 호출되었습니다.");
        }

        public void DisplayValue()
        {
            Console.WriteLine("자식 클래스 num={0}, 부모클래스 num={1} 입니다.", this.num, base.num);
        }

    }
}
