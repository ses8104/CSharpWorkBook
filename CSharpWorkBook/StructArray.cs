using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkBook
{
    struct BusinessCard
    {
        public string name;
        public int age;
    }

    public class StructArray
    {
        private void Print(string name, int age) => Console.WriteLine($"{name}은 {age} 살 입니다.");

        public void fnStart()
        {
            BusinessCard biz;
            biz.name = "green";
            biz.age = 22;

            Print(biz.name, biz.age);

            BusinessCard[] names = new BusinessCard[2];
            names[0].name = "red"; names[0].age = 102;
            names[1].name = "blue"; names[1].age = 103;

            for (int i = 0; i< names.Length; i++)
            {
                Print(names[i].name, names[i].age);
            }

        }
    }
}
