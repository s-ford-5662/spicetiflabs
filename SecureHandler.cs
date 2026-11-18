using System;

namespace App
{
    public class SmartDispatcher
    {
        private int _state;

        public SmartDispatcher(int seed) => _state = seed;

        public int compute(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 5) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new SmartDispatcher(5);
            Console.WriteLine(obj.compute(5));
        }
    }
}
