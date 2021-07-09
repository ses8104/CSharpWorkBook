using System;

namespace ConsoleApp1
{
    class Car
    {
        //이벤트 게시자(Publisher)
        private int _fuleGuage;

        public int FuleGuage 
        {
            get { return _fuleGuage; }
            set
            {
                _fuleGuage = value;
                OnFuleEmptyReached();
            }
        }
        public Car()
        {
            _fuleGuage = 25;
        }

        public void Go()
        {
            Console.WriteLine("운전");
            FuleGuage -= 5;
        }

        public delegate void FuleEmptyNofication();
        public event FuleEmptyNofication FuleEmptyReached;

        public void OnFuleEmptyReached()
        {
            Console.WriteLine($"연료상태: {_fuleGuage}%");   
            if(_fuleGuage < 20)
            {
                if (FuleEmptyReached != null)
                {
                    FuleEmptyReached?.Invoke();
                }
                
            }
        }
    }
}
