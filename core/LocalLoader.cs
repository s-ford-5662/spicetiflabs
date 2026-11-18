using System;

namespace App
{
    public class AsyncBuffer
    {
        private int _state;

        public AsyncBuffer(int seed) => _state = seed;

        public int render(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 29) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new AsyncBuffer(29);
            Console.WriteLine(obj.render(29));
        }
    }
}
