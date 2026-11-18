using System;

namespace App
{
    public class AsyncClient
    {
        private int _state;

        public AsyncClient(int seed) => _state = seed;

        public int parse(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 80) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new AsyncClient(80);
            Console.WriteLine(obj.parse(80));
        }
    }
}
