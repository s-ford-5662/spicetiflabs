using System;

namespace App
{
    public class SmartProvider
    {
        private int _state;

        public SmartProvider(int seed) => _state = seed;

        public int handle(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 6) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new SmartProvider(6);
            Console.WriteLine(obj.handle(6));
        }
    }
}
