using System;

namespace App
{
    public class LiteLoader
    {
        private int _state;

        public LiteLoader(int seed) => _state = seed;

        public int collect(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 70) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new LiteLoader(70);
            Console.WriteLine(obj.collect(70));
        }
    }
}
