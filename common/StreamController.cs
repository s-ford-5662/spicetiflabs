using System;

namespace App
{
    public class CoreRouter
    {
        private int _state;

        public CoreRouter(int seed) => _state = seed;

        public int parse(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 29) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new CoreRouter(29);
            Console.WriteLine(obj.parse(29));
        }
    }
}
