
namespace RR
{
    using System;

    public class Balking
    {
        private bool _isReady = false;

        public void Prepare()
        {
            _isReady = true;
            Console.WriteLine("Object is ready");
        }

        public void Execute()
        {
            if (!_isReady)
            {
                Console.WriteLine("Balking: Object is not ready");
                return;
            }

            Console.WriteLine("Executing task");
            _isReady = false; 
        }
    }

    public class BalkingEx
    {
        public static void Run()
        {
            Balking balking = new Balking();
            balking.Execute(); 
            balking.Prepare();
            balking.Execute(); 

        }
    }
}
