using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpWorkBook
{
    class Program //: CGetterSetter
    {
        //public override int AAA { get { return 111; } set { aaa = 222; } }

        static void Main(string[] args)
        {
            //var Signs = (new SignContext()).Sings;
            //foreach (var sign in Signs)
            //{
            //    Console.WriteLine($"{sign.SignId}, {sign.Email}, {sign.Password}");
            //}


            //Person person = new Person();
            //person.SetName("C#");
            //Console.WriteLine(person.GetName());

            //CYourCar cYourCar = new CYourCar();
            //cYourCar.Run();
            //cYourCar.Left();
            //cYourCar.Right();
            //cYourCar.Back();

            //Console.WriteLine(new Dog().Cry());
            //Console.WriteLine(new Cat().Cry());

            //AbstractAnimal dog = new Dog();
            //Console.WriteLine(dog.Cry());

            //AbstractAnimal cat = new Cat();
            //Console.WriteLine(cat.Cry());

            //Trainer trainer = new Trainer();
            //trainer.DoCry(new Dog());
            //trainer.DoCry(new Cat());

            //CPet cPet = new CPet();
            //((IDog)cPet).Eat();
            //((ICat)cPet).Eat();
            //IDog dog = new CPet();
            //dog.Eat();
            //ICat cat = new CPet();
            //cat.Eat();

            //var interfacenote = new InterfaceNote();
            //interfacenote.Go();

            //CChild cChild = new CChild();
            //cChild.Say();
            //cChild.Run();
            //cChild.Walk();


            //CEvent cEvent = new CEvent();

            //CDelegate cDelegate = new CDelegate();
            //cDelegate.Add(2,2);

            //Child child = new Child();
            //child.A();

            //Daughter daughter = new Daughter();
            //daughter.A();


            //ClassInheritance_child child = new ClassInheritance_child(20);
            //child.DisplayValue();

            //CGetterSetter cGetterSetter = new CGetterSetter();
            //Console.WriteLine("name : {0}", cGetterSetter.cName);



            //CGetterSetter a = new CGetterSetter();
            //a.AAA = 2;
            //Console.WriteLine("{0}, {1}", a.aaa, a.AAA);

            //cGetterSetter.cName = "Bruce Lee";
            //Console.WriteLine("name : {0}", cGetterSetter.cName);


            //NameOfOperation test = new NameOfOperation();
            //test.writeEnum();


            //Func<int, int, int> work = ThreadClass1.GetArea;
            //IAsyncResult asyncResult = work.BeginInvoke(10, 20, null, null);
            //Console.WriteLine("Do something in main thread");

            //int result = work.EndInvoke(asyncResult);
            //Console.WriteLine("Result: {0}", result);




            //-----------------thread pool-----------------
            //ThreadPool.QueueUserWorkItem(ThreadClass1.fnCalc);
            //ThreadPool.QueueUserWorkItem(ThreadClass1.fnCalc, 10.0); //radius=10, area=314
            //ThreadPool.QueueUserWorkItem(ThreadClass1.fnCalc, 20.0); //radius=20, area=1256



            //-----------------thread-----------------
            //Thread thread1 = new Thread(new ThreadStart(ThreadClass1.fnRun));
            //thread1.Start();

            //Thread thread2 = new Thread(new ParameterizedThreadStart(ThreadClass1.fnCalc));
            //thread2.Start(10.00);

            //Thread thread3 = new Thread(() => ThreadClass1.fnSum(10,20,30));
            //thread3.Start();



            //-----------------struct + array-----------------
            //StructArray structArray = new StructArray();
            //structArray.fnStart();


        }
    }
}
