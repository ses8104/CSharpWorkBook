using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkBook
{
    public class Person
    {
        private string ptName;
        public void SetName(string pStr) => ptName = pStr;
        public string GetName() => this.ptName;
    }
}
