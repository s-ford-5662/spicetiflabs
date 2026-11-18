using System;

namespace App
{
    public class RemoteCache
    {
        private int _state;

        public RemoteCache(int seed) => _state = seed;

        public int encode(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 78) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new RemoteCache(78);
            Console.WriteLine(obj.encode(78));
        }
    }
}
