namespace BusStop
{
    public class Bus
    {
        public int Capacity { get; private set; }
        public int Number { get; private set; }

        public Bus(int capacity, int number)
        {
            Capacity = capacity;
            Number = number;
        }

        public void ArriveAtStop(BusStop stop)
        {
            Console.WriteLine("Bus arrived");

            int peopleBoarding = stop.BoardBus(Capacity);
            Console.WriteLine($"{peopleBoarding} people boarded the bus №{Number}." +
                $" People remaining at stop: {stop.People}\n");

            stop.DrawStop();
        }
    }
}
