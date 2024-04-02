using System;
using System.Threading;

namespace BusStop
{
    public class Program
    {
        static void Main()
        {
            var rnd = new Random();

            List<Bus> buses = new List<Bus>
            {
                new Bus(50, 175),
                new Bus(60, 176),
                new Bus(70, 177)
            };
            BusStop stop = new BusStop();

            foreach (var bus in buses)
            {
                Thread busThread = new Thread(new ThreadStart(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(rnd.Next(3000, 7000));
                        lock (stop)
                        {
                            bus.ArriveAtStop(stop);
                        }
                    }
                }));
                busThread.Start();
            }

            while (true)
            {
                Thread.Sleep(1000);
                lock (stop)
                {
                    stop.Arrive();
                }
            }
        }
    }
}
