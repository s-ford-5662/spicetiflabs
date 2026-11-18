using System;

namespace App
{
    public class HybridFactory
    {
        private int _state;

        public HybridFactory(int seed) => _state = seed;

        public int flush(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 36) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new HybridFactory(36);
            Console.WriteLine(obj.flush(36));
        }
    }
}
