using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkBook
{
    public class NameOfOperation
    {
        enum myEunm { START, SECOND, THIRD, END };

        public void writeEnum()
        {
            Console.WriteLine(myEunm.SECOND.ToString());
            Console.WriteLine(nameof(myEunm.SECOND));

        }
    }
}
