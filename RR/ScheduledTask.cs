
namespace RR
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class ScheduledTaskEx
    {
        private static Timer _timer;

        public static void Start()
        {
            _timer = new Timer(ExecuteTask, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
        }

        private static void ExecuteTask(object state)
        {
            Console.WriteLine($"Task executed at {DateTime.Now}");
        }
    }
}
