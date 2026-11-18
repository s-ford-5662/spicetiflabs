using System;

namespace App
{
    public class LocalWorker
    {
        private int _state;

        public LocalWorker(int seed) => _state = seed;

        public int resolve(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 64) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new LocalWorker(64);
            Console.WriteLine(obj.resolve(64));
        }
    }
}
