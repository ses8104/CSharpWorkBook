using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkBook
{
    public class ThreadClass1
    {
        public static void fnRun()
        {
            Console.WriteLine("Run...");
        }
        public static void fnCalc(object radius)
        {
            double r = (double)radius;
            double area = r * r * 3.14;
            Console.WriteLine("radius={0}, area={1}",r, area);
        }

        public static void fnSum(int d1, int d2, int d3)
        {
            int sum = d1 + d2 + d3;
            Console.WriteLine(sum);
        }

        public static int GetArea(int height, int width)
        {
            int area = height * width;
            return area;
        }
    }
}
