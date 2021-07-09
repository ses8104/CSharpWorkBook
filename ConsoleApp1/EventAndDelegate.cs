using System;

namespace ConsoleApp1
{
    //이벤트 구독자(Subscriber)
    class EventAndDelegate
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.FuleEmptyReached += Car_FuleEmtpyReached;
            car.Go();
        }

        private static void Car_FuleEmtpyReached()
        {
            Console.WriteLine("연료부족");
        }

    }
}
