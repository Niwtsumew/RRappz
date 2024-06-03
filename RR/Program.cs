using RR;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Prototype Demo:");
        PrototypeEx.Run();

        Console.WriteLine("\nComposite Demo:");
        CompositeEx.Run();

        Console.WriteLine("\nScheduled Task Demo:");
        ScheduledTaskEx.Start();

        await Task.Delay(TimeSpan.FromSeconds(10));

        Console.WriteLine("\nBalking Demo:");
        BalkingEx.Run();
    }
}