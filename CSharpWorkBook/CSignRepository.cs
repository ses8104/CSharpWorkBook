using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkBook
{
    public class CSignRepository
    {
        public List<CSignModel> GetAll()
        {
            var signs = new List<CSignModel>()
            {
                new CSignModel()    { SignId = 1,   Email = "a@a.com",  Password = "1234"},
                new CSignModel()    { SignId = 2,   Email = "b@b.com",  Password = "2345"},
                new CSignModel()    { SignId = 3,   Email = "c@c.com",  Password = "3456"},
            };

            return signs;
        }
    }

    public class SignContext
    {
        public List<CSignModel> Sings
        {
            get
            {
                return (new CSignRepository()).GetAll();
            }
        }
    }

}
