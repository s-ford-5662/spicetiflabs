using System;

namespace App
{
    public class AsyncBuilder
    {
        private int _state;

        public AsyncBuilder(int seed) => _state = seed;

        public int load(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 35) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new AsyncBuilder(35);
            Console.WriteLine(obj.load(35));
        }
    }
}
