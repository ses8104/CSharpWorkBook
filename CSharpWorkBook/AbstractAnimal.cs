using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkBook
{
    public abstract class AbstractAnimal
    {
        public abstract string Cry();

    }

    public class Dog : AbstractAnimal
    {
        public override string Cry()
        {
            //throw new NotImplementedException();
            return "강아지가 멍멍하고 찢습니다.";
        }
    }

    public class Cat : AbstractAnimal
    {
        public override string Cry()
        {
            //throw new NotImplementedException();
            return "고양이가 야옹하고 웁니다.";
        }
    }

    public class Trainer
    {
        public void DoCry(AbstractAnimal animal)
        {

            Console.WriteLine("{0}", animal.Cry()); //다형성: Dynamic(동적)
        }
    }


}
