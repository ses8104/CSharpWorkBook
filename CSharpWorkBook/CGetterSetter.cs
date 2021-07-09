using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkBook
{
    public class CGetterSetter
    {
        private string name = "alvin";

        public string cName
        {
            get { return name; }
            set { name = value; }
        }


        public int aaa;

        public virtual int AAA
        {
            get { return aaa + 1; }
            set { aaa = value + 1; }
        }
    }
}
