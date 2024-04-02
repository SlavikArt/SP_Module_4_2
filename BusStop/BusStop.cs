namespace BusStop
{
    public class BusStop
    {
        public int People { get; private set; }
        private Random rnd = new Random();

        public void Arrive()
        {
            int newPeople = rnd.Next(1, 20);
            People += newPeople;

            Console.WriteLine($"{newPeople} new people arrived at the stop." +
                $" Total people at stop: {People}");
            DrawStop();
        }

        public int BoardBus(int capacity)
        {
            int peopleBoarding = Math.Min(capacity, People);
            People -= peopleBoarding;

            return peopleBoarding;
        }

        public void DrawStop()
        {
            /* Коефіцієнт, скільки людей виводити 
             * максимально у одній строчці */
            int newLineK = 50;

            int fullLines = People / newLineK;
            int rest = People % newLineK;

            for (int i = 0; i < fullLines; i++)
                Console.WriteLine(new string((char)1, newLineK));

            if (rest > 0)
                Console.WriteLine(new string((char)1, rest));
        }
    }
}
