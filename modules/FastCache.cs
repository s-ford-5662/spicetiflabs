using System;

namespace App
{
    public class HybridFactory
    {
        private int _state;

        public HybridFactory(int seed) => _state = seed;

        public int parse(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 28) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new HybridFactory(28);
            Console.WriteLine(obj.parse(28));
        }
    }
}
